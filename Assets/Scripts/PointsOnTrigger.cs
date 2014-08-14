using UnityEngine;
using System.Collections;

public class PointsOnTrigger : MonoBehaviour {
	
	public float pointIncrease = 100;
	void OnTriggerEnter(){
		if(!GameManager.Instance.gameOver){
			GameManager.Instance.score += pointIncrease*GameManager.Instance.pointsPerUnit;
			audio.Play();
		}
	}
}
