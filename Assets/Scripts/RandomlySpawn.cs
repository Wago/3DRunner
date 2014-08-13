using UnityEngine;
using System.Collections;

public class RandomlySpawn : MonoBehaviour {

	public GameObject obstacle;

	public float minSpawnTime = 1.0f;
	public float maxSpawnTime = 2.0f;

	public float minHorizontalPosition = -1.0f;
	public float maxHorizontalPosition = 1.0f;
	public float minVerticalPosition = -1.0f;
	public float maxVerticalPosition = 1.0f;

	// Use this for initialization
	void Start () {
	
		Invoke ("SpawnNow", Random.Range(minSpawnTime, maxSpawnTime));

	}

	void SpawnNow(){
		Instantiate(obstacle, transform.position + new Vector3(Random.Range(minHorizontalPosition,maxHorizontalPosition),
		                                                       Random.Range(minVerticalPosition,maxVerticalPosition)),
		            										   Quaternion.identity);

		Invoke ("SpawnNow", Random.Range(minSpawnTime, maxSpawnTime));
	
	}
}
