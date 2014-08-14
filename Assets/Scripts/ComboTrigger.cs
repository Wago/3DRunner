using UnityEngine;
using System.Collections;

public class ComboTrigger : MonoBehaviour {

	public float Increase = 1;
	void OnTriggerEnter(){
		GameManager.Instance.pointsPerUnit += Increase;
		audio.Play();
	}
}
