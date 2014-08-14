using UnityEngine;
using System.Collections;

public class SimpleJump : MonoBehaviour {

	public float jumpForce = 1.0f;
	public bool jumped = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Jump") && transform.position.y <= 1.0f){
			rigidbody.AddForce(0,jumpForce,0);
		}
	}
}
