using UnityEngine;
using System.Collections;

public class AnimateTexture : MonoBehaviour {

	public Vector2 speed = Vector2.zero;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//Changes the offset on the main texture assigned to this current object
		renderer.material.mainTextureOffset += speed * Time.deltaTime;
	}
}
