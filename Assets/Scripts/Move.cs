using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	//Direction and speed to move.
	public Vector3 direction = Vector3.forward;
	public float speed = 1.0f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//Movies current object in direction (clarified above), based on speed set above(or in the inspector.
		transform.position += transform.rotation*(direction.normalized*speed*Time.deltaTime);
	}
}
