using UnityEngine;
using System.Collections;

public class CarSpawner : MonoBehaviour {
	
	public GameObject[] obstacles;
	public float xRange = 1.0f;
	public float yRange = 1.0f;
	public float minSpawnTime = 1.0f;
	public float maxSpawnTime = 1.0f;
	public float spawnsPerSpeedUnit = 0.1f;

	void Start(){
		Invoke ("SpawnWall", Random.Range(minSpawnTime, maxSpawnTime));
	}
	void SpawnWall(){
		for(int i = (int)(spawnsPerSpeedUnit*GameManager.Instance.gameSpeed); i > 0; i--){
			int obstablesIndex = Random.Range(0,obstacles.Length);
			Instantiate(obstacles[obstablesIndex],transform.position+new Vector3(Random.Range(-xRange,xRange),Random.Range(-yRange,yRange),0.0f),obstacles[obstablesIndex].transform.rotation);
		}
		Invoke ("SpawnWall", Random.Range(minSpawnTime, maxSpawnTime));
	}
}
