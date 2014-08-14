using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	//Referance it self for use else where, also appears when referanced if not already there.
	public static GameManager Instance{
		get{
			//If _instance is not null return, else create a new game object
			if(_instance != null){
				return _instance;
			}else{
				GameObject gameManager = new GameObject("GameManager");
				_instance = gameManager.AddComponent<GameManager>();
				return _instance;
			}
		}
	}

	//Referance it self for use in THIS scripts.
	private static GameManager _instance;

	//Points per unit travelled and a unified game speed to move at
	public float pointsPerUnitTravelled = 1.0f;
	public float gameSpeed = 10.0f;
	public string titleScreen = "Title";
	public string highscoreScreen = "Highscore";

	[HideInInspector] //This hides it in the inspector, but it can still be seen by other scripts.
	public int previousScore = 0;

	//Just some variables
	private float score = 0.0f;
	private static float highScore = 0.0f;
	private bool gameOver = false;
	private bool hasSaved = false;

	// Use this for initialization
	void Start () {
		//Only do all of this if _instance is not this.
		if(_instance != this){
			//Only set this if its not already set.
			if(_instance == null){
				//Make sure Instance is a referance to THIS game object!
				_instance = this;
			//If instance is already set destory it.
			}else{
				Destroy(gameObject);
			}
		}
		//Loads the highscore from the playerprefs.
		LoadHighScore();
		//Don't destory this game object on start, that way we can bring it in to the next scene.
		DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		//Only do this if you are not on the title screen!
		if(Application.loadedLevelName != titleScreen &&
		   Application.loadedLevelName != highscoreScreen){
			//Find game object with the tag player, and if that object don't exsist put game over to true.
			if(GameObject.FindGameObjectWithTag("Player") == null){
				gameOver = true;
			}
			//When game over is true, and key will restart the current loaded level
			if(gameOver){
				//If its not saved run this.
				if(!hasSaved){
					//Save highscore to playerpref.
					SaveHighScore();
					//Set previous score to current score.
					previousScore = (int)score;
					//Make sure this if statement is not run again.
					hasSaved = true;
				}if(!IsMobile()){
					if(Input.anyKeyDown){
						Application.LoadLevel("Title");
					}
				}else{
					foreach(Touch touch in Input.touches){
						if(touch.phase == TouchPhase.Began){
							Application.LoadLevel("Title");
						}
					}
				}
				//On any keypress load the level named Title
			}
			//When game over is true stop counting score
			if(!gameOver){
				score += pointsPerUnitTravelled*gameSpeed*Time.deltaTime;
				if(score > highScore){
					highScore = score;
				}
			}
		}else{
			//Resets things
			ResetGame();
		}
		//Debug function to reset the highscore, when Y is pressed, then saves it to the playerpref.
		if(Input.GetKeyDown(KeyCode.Y)){
			highScore = 0;
			SaveHighScore();
		}
	}
	//Sets up for a reset;
	void ResetGame(){
		score = 0.0f;
		gameOver = false;
		hasSaved = false;
	}
	//Pusheds the highscore to the playerpref(A file saved locally on all platforms.
	//Then saves it!
	void SaveHighScore(){
		PlayerPrefs.SetInt("Highscore",(int)highScore);
		PlayerPrefs.Save();
	}
	//Loads the highscore saved above.
	void LoadHighScore(){
		highScore = PlayerPrefs.GetInt("Highscore");
	}

	void OnGUI(){
		//Only display the gui text when not on the title screen.
		if(Application.loadedLevelName != titleScreen &&
		    Application.loadedLevelName != highscoreScreen){
			//Convert current score to an in and display it on the screen
			int currentScore = (int)score;
			GUILayout.Label("Score: " + currentScore.ToString());

			//Convert current HIGH score to an in and display it on the screen
			int currentHighScore = (int)highScore;
			GUILayout.Label("High Score: " + currentHighScore.ToString());

			//When game over becomes true (you die) display text!
			if(gameOver == true){
				GUILayout.Label("Game over! Press any key to quit!");
			}
		}
	}

	public static bool IsMobile(){
		if (Application.platform == RuntimePlatform.IPhonePlayer ||
		    Application.platform == RuntimePlatform.Android ||
		    Application.platform == RuntimePlatform.BlackBerryPlayer ||
		    Application.platform == RuntimePlatform.MetroPlayerARM ||
		    Application.platform == RuntimePlatform.WP8Player){
			return true;
		}else{
			return false;
		}
	}
}
