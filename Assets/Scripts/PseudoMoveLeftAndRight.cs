using UnityEngine;
using System.Collections;

public class PseudoMoveLeftAndRight : MonoBehaviour {

	public float speed = 1.0f;
	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
		//Changes the offset on the texture of the current object to give the illusion of horizontal movement based on the speed set above or in the inspector.
		renderer.material.mainTextureOffset += Vector2.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime;
	}
}
