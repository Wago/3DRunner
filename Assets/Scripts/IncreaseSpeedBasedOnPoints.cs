using UnityEngine;
using System.Collections;

public class IncreaseSpeedBasedOnPoints : MonoBehaviour {
	
	public float divideWith = 1.0f;

	private float speed;
	private float score;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		speed = GameManager.Instance.gameSpeed;
		score = GameManager.Instance.score/divideWith;
		GameManager.Instance.gameSpeed += score*Time.deltaTime;
	}
}
