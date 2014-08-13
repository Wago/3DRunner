using UnityEngine;
using System.Collections;

public class DestroyBehindCamera : MonoBehaviour {

	public float destroyValue = 0.0f;
	
	// Update is called once per frame
	void Update () {
		//When this current objects gets past set Z coordinate it is destoryed. Used to destroy things when they are behind the camera.
		if(transform.position.z <= destroyValue){
			Destroy (gameObject);
		}
	}
}
