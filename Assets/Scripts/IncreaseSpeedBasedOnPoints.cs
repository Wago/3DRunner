using UnityEngine;
using System.Collections;

public class IncreaseSpeedBasedOnPoints : MonoBehaviour {
	
	public float divideWith = 1.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float score = GameManager.Instance.score/divideWith;
		GameManager.Instance.gameSpeed += score*Time.deltaTime;
	}
}
