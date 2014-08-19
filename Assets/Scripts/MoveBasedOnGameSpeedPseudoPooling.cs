using UnityEngine;
using System.Collections;

public class MoveBasedOnGameSpeedPseudoPooling : MonoBehaviour {

	//Direction to move.
	public Vector3 direction = Vector3.forward;
	public float moveWhenAtX = -30.0f;
	public float MoveToX = 730.0f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//Movies current object in direction (clarified above), based on speed set on the game manager.
		transform.position += transform.rotation*(direction.normalized*GameManager.Instance.gameSpeed*Time.deltaTime);
		if(transform.position.z < moveWhenAtX){
			transform.position = new Vector3(transform.position.x,transform.position.y,MoveToX);
		}
	}
}
