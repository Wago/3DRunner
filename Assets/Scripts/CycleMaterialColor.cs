using UnityEngine;
using System.Collections;

public class CycleMaterialColor : MonoBehaviour {

	public string colorPropertyName = "_Color";
	public float speed = 0.1f;
	public float saturation = 1.0f;
	public float brightness = 1.0f;
	public float hue = 0.0f;

	// Use this for initialization
	void Start () {
		//StartCoroutine("CycleColors");
	}

	void Update(){
		hue += speed*Time.deltaTime;
		while(hue > 1.0f){
			hue -= 1.0f;
		}while(hue < 0.0f){
			hue += 1.0f;
		}

		renderer.material.SetColor(colorPropertyName,new HSBColor(hue,saturation,brightness).ToColor());
	}

	/*Old version with lerping
	IEnumerator CycleColors () {

		float t = 0.0f;
		float hue = 0.0f;

		while(t < cycleTime) {
			hue = Mathf.Lerp(0.0f,1.0f,t/cycleTime);
			renderer.material.color = new HSBColor(hue, saturation,brightness).ToColor();
			t += Time.deltaTime;
			yield return null;
		}

		hue = 1.0f;

		StartCoroutine("CycleColors");
	}*/
}
