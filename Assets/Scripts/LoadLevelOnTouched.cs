using UnityEngine;
using System.Collections;

public class LoadLevelOnTouched : MonoBehaviour {

	public string levelName;
	public bool startOnEnter = false;

	void Update(){
		if(Input.GetKey(KeyCode.Return) && startOnEnter == true){
			Application.LoadLevel(levelName);
		}
	}
	
	void Touched(){
		Application.LoadLevel(levelName);
	}
}
