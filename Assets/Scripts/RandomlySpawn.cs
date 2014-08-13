using UnityEngine;
using System.Collections;

public class RandomlySpawn : MonoBehaviour {

	//Choose what to spawn	
	public GameObject obstacle;

	//How often will it spawn object set above.
	public float minSpawnTime = 1.0f;
	public float maxSpawnTime = 2.0f;

	//Where will it spawn them
	public float minHorizontalPosition = -1.0f;
	public float maxHorizontalPosition = 1.0f;
	public float minVerticalPosition = -1.0f;
	public float maxVerticalPosition = 1.0f;

	// Use this for initialization
	void Start () {
		//Invokes SpawnNow based on the time set above or in the inspector.
		Invoke ("SpawnNow", Random.Range(minSpawnTime, maxSpawnTime));
	}

	void SpawnNow(){
		//Spawns the object, in a random position based on variables above(also set in the inspector), no Z position or rotation.
		Instantiate(obstacle, transform.position + new Vector3(Random.Range(minHorizontalPosition,maxHorizontalPosition),
		                                                       Random.Range(minVerticalPosition,maxVerticalPosition)),
		            										   Quaternion.identity);
		//Invokes SpawnNow again after previous object is spawned.
		Invoke ("SpawnNow", Random.Range(minSpawnTime, maxSpawnTime));
	
	}
}
