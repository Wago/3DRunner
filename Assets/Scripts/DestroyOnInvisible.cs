using UnityEngine;
using System.Collections;

public class DestroyOnInvisible : MonoBehaviour {
	//Destroy current object when it can no longer be seen by any camera.
	void OnBecameInvisible(){
		Destroy(gameObject);
	}
}
