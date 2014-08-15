using UnityEngine;
using System.Collections;

public class TakeScreenshots : MonoBehaviour {
	
	public int superSize = 4;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.P)){
			Application.CaptureScreenshot("Screenshot " + System.DateTime.Now.ToString("yyMMdd hmmss")+".PNG",superSize);
			Debug.Log ("Screenshot taken, saved as Screenshot" + System.DateTime.Now.ToString("yyMMdd hmmss")+".PNG");
		}
	}
}
