using UnityEngine;
using System.Collections;

public class DisplayHighScore : MonoBehaviour {

	private string label;

	// Use this for initialization
	void Start () {
		//Get the text mesh on the current object and save it as textMesh
		TextMesh textMesh = GetComponent<TextMesh>();
		//Grabs the current text and assigns it to label.
		label = textMesh.text;
		//set the text to label + highscore!
		textMesh.text = label + PlayerPrefs.GetInt("Highscore");
	}
}
