using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	//Referance it self for use in other scripts.
	public static GameManager Instance;

	//Points per unit travelled and a unified game speed to move at
	public float pointsPerUnitTravelled = 1.0f;
	public float gameSpeed = 10.0f;
	public string titleScreen = "Title";

	//Just some variables
	private float score = 0.0f;
	private static float highScore = 0.0f;
	private bool gameOver = false;
	private bool hasSaved = false;

	// Use this for initialization
	void Start () {
		//Make sure Instance is a referance to THIS game object!
		Instance = this;
		//Loads the highscore from the playerprefs.
		LoadHighScore();
	}
	
	// Update is called once per frame
	void Update () {
		//Find game object with the tag player, and if that object don't exsist put game over to true.
		if(GameObject.FindGameObjectWithTag("Player") == null){
			gameOver = true;
		}
		//When game over is true, and key will restart the current loaded level
		if(gameOver){
			if(!hasSaved){
				SaveHighScore();
				hasSaved = true;
			}if(Input.anyKeyDown){
				Application.LoadLevel("Title");
			}
		}
		//When game over is true stop counting score
		if(!gameOver){
			score += pointsPerUnitTravelled*gameSpeed*Time.deltaTime;
			if(score > highScore){
				highScore = score;
			}
		}
		//Debug function to reset the highscore, when Y is pressed, then saves it to the playerpref.
		if(Input.GetKeyDown(KeyCode.Y)){
			highScore = 0;
			SaveHighScore();
		}
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
