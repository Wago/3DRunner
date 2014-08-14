using UnityEngine;
using System.Collections;

public class HUDGameOverText : MonoBehaviour {

	public string textLine1 = "Game Over!";
	public string textLine2 = "FinalScore: ";
	public string textLine3 = "Press Any Key To Start Over";
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		int currentScore = (int)GameManager.Instance.score;
		if(GameManager.Instance.gameOver){
			guiText.enabled = true;
			guiText.text = textLine1+"\n"+textLine2+currentScore+"\n"+textLine3;
		}else{
			guiText.enabled = false;
		}
	}
}
