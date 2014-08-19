using UnityEngine;
using System.Collections;

public class MoveLeftAndRightBasedOnGameSpeed : MonoBehaviour {
		
	public bool invertDirection = false;
	public bool lockMovement = true;
	public float LockOnX = 9.5f;
	public bool dashEnable = false;
	public float dashSpeed = 2.0f;
	public float dashDuration = 1.0f;
	public float doubleTapSpeed = 0.25f;
	
	private float lastTap = 0.0f;
	private bool pressedLeftLast = false;
	private bool pressedRightLast = false;
	private bool buttonPressed = false;
	
	private static bool isDashing = false;
	private static float dashDirection = 0.0f;
	private static float t = 0.0f;

	private float speed = 0.0f;

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
		if(lockMovement){
			if(transform.position.x <= -LockOnX){
				transform.position = new Vector3(-LockOnX,transform.position.y,transform.position.z);
			}else if(transform.position.x >= LockOnX){
				transform.position = new Vector3(LockOnX,transform.position.y,transform.position.z);
			}
		}

		if(dashEnable == true){
			speed = -GameManager.Instance.gameSpeed;
			dashSpeed = -GameManager.Instance.gameSpeed*2;
			if(!isDashing){
				//Moves what ever gameobject this is assigned to Horizontally based on keybaord inputs.
				transform.position += Vector3.right*Input.GetAxis("Horizontal")*speed*Time.deltaTime;
			}
			//Dash Right
			if(Input.GetAxis("Horizontal") > 0.0f){
				if(pressedLeftLast && !buttonPressed && lastTap <= doubleTapSpeed){
					Debug.Log ("DashRight");
					t = Time.time;
					dashDirection = 1.0f;
					StopAllCoroutines();
					StartCoroutine(Dash(dashSpeed*dashDirection));
					buttonPressed = true;
				}else if(!isDashing){
					transform.position += Vector3.right*speed*Time.deltaTime;
					lastTap = 0.0f;
					pressedRightLast = false;
					pressedLeftLast = true;
					buttonPressed = true;
				}
			}
			//Dash Left
			if(Input.GetAxis("Horizontal") < 0.0f){
				if(pressedRightLast && !buttonPressed && lastTap <= doubleTapSpeed){
					Debug.Log ("DashLeft");
					t = Time.time;
					dashDirection = -1.0f;
					StopAllCoroutines();
					StartCoroutine(Dash(dashSpeed*dashDirection));
					buttonPressed = true;
				}else if(!isDashing){
					transform.position += Vector3.left*speed*Time.deltaTime;
					lastTap = 0.0f;
					pressedRightLast = true;
					pressedLeftLast = false;
					buttonPressed = true;
				}
			}
			if(Input.GetAxis("Horizontal") == 0.0f){
				buttonPressed = false;
			}
			lastTap += Time.deltaTime;
		}
	}

	IEnumerator Dash(float speed){
		isDashing = true;

		while(Time.time - t <= dashDuration){
			transform.position +=Vector3.right*speed*Time.deltaTime;
			yield return null;
		}
		isDashing = false;
	}
}
