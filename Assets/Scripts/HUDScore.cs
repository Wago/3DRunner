using UnityEngine;
using System.Collections;

public class HUDScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		int currentScore = (int)GameManager.Instance.score;
		guiText.text = "Distance: " + currentScore;
	}
}
