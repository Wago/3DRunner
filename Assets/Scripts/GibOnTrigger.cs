using UnityEngine;
using System.Collections;

public class GibOnTrigger : MonoBehaviour {

	//Assign a object to spawn when current object gets destryed (AKA a gib).
	public GameObject gib;

	//When something enters current objects trigger, spawn above gib and destroy it self.
	void OnTriggerEnter(){
		Instantiate(gib, transform.position,Quaternion.identity);
		Destroy(gameObject);
	}

}
