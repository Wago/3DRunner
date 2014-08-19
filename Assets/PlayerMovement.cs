using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	
	public bool invertDirection = false;
	public bool lockMovementInX = true;
	public float LockOnX = 9.5f;

	private float speed = 0.0f;

	public float movementSpeed = 1.0f;
	public int invert = -1; //-1 Inverted 1; none inverted
	public float maxDegrees = 30.0f;
	public float zValue = 10.0f;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(invertDirection){
			speed = -GameManager.Instance.gameSpeed;
		}else{
			speed = GameManager.Instance.gameSpeed;
		}
		
		transform.position += Vector3.right*Input.GetAxis("Horizontal")*speed*Time.deltaTime;
		
		//Prevent movement in X
		if(lockMovementInX){
			if(transform.position.x <= -LockOnX){
				transform.position = new Vector3(-LockOnX,transform.position.y,transform.position.z);
			}else if(transform.position.x >= LockOnX){
				transform.position = new Vector3(LockOnX,transform.position.y,transform.position.z);
			}
		}	
		float horizontal = Input.GetAxis("Horizontal");
		Vector3 direction = new Vector3(horizontal,0,0);
		Vector3 finalDirection = new Vector3(horizontal,0,zValue);
		
		transform.position += direction*movementSpeed*Time.deltaTime;
		
		transform.rotation = Quaternion.RotateTowards(transform.rotation,Quaternion.LookRotation(finalDirection),Mathf.Deg2Rad*maxDegrees);


	}
}
