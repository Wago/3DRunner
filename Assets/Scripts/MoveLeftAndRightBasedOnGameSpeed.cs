using UnityEngine;
using System.Collections;

public class MoveLeftAndRightBasedOnGameSpeed : MonoBehaviour {

	private float speed = 0.0f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		speed = -GameManager.Instance.gameSpeed;
		//Moves what ever gameobject this is assigned to Horizontally based on keybaord inputs.
		transform.position += Vector3.right*Input.GetAxis("Horizontal")*speed*Time.deltaTime;

		if(PseudoInput.Instance.leftPressed){
			transform.position += Vector3.left*speed*Time.deltaTime;
		}
		if(PseudoInput.Instance.rightPressed){
			transform.position += Vector3.right*speed*Time.deltaTime;
		}
	}
}
