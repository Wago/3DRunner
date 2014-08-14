using UnityEngine;
using System.Collections;

public class ComboTrigger : MonoBehaviour {

	public float Increase = 1;
	void OnTriggerEnter(){
		if(!GameManager.Instance.gameOver){
			GameManager.Instance.pointsPerUnit += Increase;
			audio.Play();
		}
	}
}
