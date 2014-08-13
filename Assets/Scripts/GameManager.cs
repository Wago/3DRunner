﻿using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	//Referance it self for use in other scripts.
	public static GameManager Instance;

	//Points per unit travelled and a unified game speed to move at
	public float pointsPerUnitTravelled = 1.0f;
	public float gameSpeed = 10.0f;

	//Just some variables for score and gameover state
	private float score = 0.0f;
	private static float highScore = 0.0f;
	private bool gameOver = false;

	// Use this for initialization
	void Start () {
		//Make sure Instance is a referance to THIS game object!
		Instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		//Find game object with the tag player, and if that object don't exsist put game over to true.
		if(GameObject.FindGameObjectWithTag("Player") == null){
			gameOver = true;
		}
		//When game over is true, and key will restart the current loaded level
		if(gameOver){
			if(Input.anyKeyDown){
				Application.LoadLevel(Application.loadedLevel);
			}
		}
		//When game over is true stop counting score
		if(!gameOver){
			score += pointsPerUnitTravelled*gameSpeed*Time.deltaTime;
			if(score > highScore){
				highScore = score;
			}
		}

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
			GUILayout.Label("Game over! Press any key to reset!");
		}

	}
}
