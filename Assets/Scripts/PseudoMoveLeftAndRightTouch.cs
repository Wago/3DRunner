using UnityEngine;
using System.Collections;

public class PseudoMoveLeftAndRightTouch : MonoBehaviour {

	public float speed = 1.0f;
	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
		if(PseudoInput.Instance.leftPressed){
			renderer.material.mainTextureOffset -= Vector2.right*speed*Time.deltaTime;
		}
		if(PseudoInput.Instance.rightPressed){
			renderer.material.mainTextureOffset += Vector2.right*speed*Time.deltaTime;
		}
	}
}
