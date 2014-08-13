using UnityEngine;
using System.Collections;

public class MoveBasedOnGameSpeed : MonoBehaviour {

	//Direction to move.
	public Vector3 direction = Vector3.forward;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//Movies current object in direction (clarified above), based on speed set on the game manager.
		transform.position += transform.rotation*(direction.normalized*GameManager.Instance.gameSpeed*Time.deltaTime);
	}
}
