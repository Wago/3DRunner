using UnityEngine;
using System.Collections;

public class LoadLevelOnAnyKey : MonoBehaviour {

	public string levelName;

	// Use this for initialization
	void Start(){
	}
	// Update is called once per frame
	void Update(){
		//Press any key to load level assigned above.
		if(Input.anyKeyDown){
			Application.LoadLevel(levelName);
		}
	}
}
