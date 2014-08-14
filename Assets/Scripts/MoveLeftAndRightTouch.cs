using UnityEngine;
using System.Collections;

public class MoveLeftAndRightTouch : MonoBehaviour {

	public float speed = 1.0f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(PseudoInput.Instance.leftPressed){
			transform.position += Vector3.left*speed*Time.deltaTime;
		}
		if(PseudoInput.Instance.rightPressed){
			transform.position += Vector3.right*speed*Time.deltaTime;
		}
	}
}
