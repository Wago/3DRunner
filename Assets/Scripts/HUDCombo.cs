using UnityEngine;
using System.Collections;

public class HUDCombo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		int currentPointsPerUnit = (int)GameManager.Instance.pointsPerUnit;
		guiText.text = "Combo: " + currentPointsPerUnit;
	}
}
