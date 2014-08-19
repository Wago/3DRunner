using UnityEngine;
using System.Collections;

public class LimitCameraFollowX : MonoBehaviour {

	public Transform objectToFollow;
	public Vector2 movementRatio = Vector2.zero;
	private Vector3 newPosition = Vector3.zero;
	
	void Update () {
		newPosition = objectToFollow.position;
		newPosition.x *= movementRatio.x;
		newPosition.y = transform.position.y;
		newPosition.z = transform.position.z;
		transform.position = newPosition;
	}
}


