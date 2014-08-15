using UnityEngine;
using System.Collections;

public class RandomRotationOnSpawn : MonoBehaviour {

	//How often will it spawn object set above.
	public float minRotation = 1.0f;
	public float maxRotation = -1.0f;
	

	// Use this for initialization
	void Awake(){
		transform.Rotate(Random.Range(minRotation, maxRotation),
		                 Random.Range(minRotation, maxRotation),
		                 Random.Range(minRotation, maxRotation));
	}
}
