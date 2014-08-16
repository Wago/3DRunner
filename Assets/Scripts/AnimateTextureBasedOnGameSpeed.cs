using UnityEngine;
using System.Collections;

public class AnimateTextureBasedOnGameSpeed : MonoBehaviour {

	private Vector2 speed = Vector2.zero;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		speed = new Vector2(0, GameManager.Instance.gameSpeed/4);
		//Changes the offset on the main texture assigned to this current object
		renderer.material.mainTextureOffset += speed * Time.deltaTime;
	}
}
