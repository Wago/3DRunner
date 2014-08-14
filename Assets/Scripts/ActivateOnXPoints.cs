using UnityEngine;
using System.Collections;

public class ActivateOnXPoints : MonoBehaviour {

	public float pointsToActivateOn = 0.0f;
	public GameObject spawner;
	private float score = 0.0f;
	void Update () {
		score = GameManager.Instance.score;
		if(GameManager.Instance.score >= pointsToActivateOn){
			spawner.gameObject.SetActive(true);
		}
	}
}
