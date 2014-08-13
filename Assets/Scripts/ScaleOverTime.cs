using UnityEngine;
using System.Collections;

public class ScaleOverTime : MonoBehaviour {

	//What scale current object will end up at,
	//How long the scaling will take. Both can be set in the inspector.
	public Vector3 finalScale = Vector3.zero;
	public float time = 1.0f;

	//Current scale, takes the current scale of current object and set it as below variable in the star funciton.
	private Vector3 initialScale;

	// Use this for initialization
	void Start () {
		initialScale = transform.localScale;
		StartCoroutine("Scale");
	}

	IEnumerator Scale(){
		//resets T to 0.
		float t = 0.0f;

		// If t is less then time scale current object from initial scale to the final scale based on time.
		while(t <= time){
			transform.localScale = Vector3.Lerp(initialScale,finalScale,t/time);
			t += Time.deltaTime;
			yield return null;
		}
		//Make sure object is at the correct scale.
		transform.localScale = finalScale;
	}
}
