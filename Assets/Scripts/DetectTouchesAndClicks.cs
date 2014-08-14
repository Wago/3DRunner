using UnityEngine;
using System.Collections;

public class DetectTouchesAndClicks : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButton(0)){
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			RaycastHit hit;

			if(Physics.Raycast(ray, out hit)){
				Debug.Log ("Object name: " + hit.collider.name, hit.collider.gameObject);
			}
		}
	}
}
