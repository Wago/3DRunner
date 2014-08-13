using UnityEngine;
using System.Collections;

public class DisplayPreviousScore : MonoBehaviour {

	private string label;
	
	// Use this for initialization
	void Start () {
		//Get the text mesh on the current object and save it as textMesh
		TextMesh textMesh = GetComponent<TextMesh>();
		//Grabs the current text and assigns it to label.
		label = textMesh.text;
		//Loads the previous score from the game manger, and displays is after the lable!
		textMesh.text = label + GameManager.Instance.previousScore;
	}
}
