using UnityEngine;
using System.Collections;

public class ResetHighScoresOnTouch : MonoBehaviour {

	void Touched(){
		PlayerPrefs.DeleteAll();
		Application.LoadLevel("Highscore");
	}
}
