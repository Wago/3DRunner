using UnityEngine;
using System.Collections;

public class HUDHighScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		int currentHighScore = (int)GameManager.Instance.tempHighScore;
		guiText.text = "Highscore: " + currentHighScore;
	}
}
