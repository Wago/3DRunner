using UnityEngine;
using System.Collections;

public class HUDSpeed : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		int currentSpeed = (int)GameManager.Instance.gameSpeed;
		guiText.text = "Speed: " + currentSpeed;
	}
}
