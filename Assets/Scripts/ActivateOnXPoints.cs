using UnityEngine;
using System.Collections;

public class ActivateOnXPoints : MonoBehaviour {

	public float pointsToActivateOn = 0.0f;
	public GameObject spawner;

	void Update () {
		if(GameManager.Instance.score >= pointsToActivateOn){
			spawner.gameObject.SetActive(true);
		}
	}
}
