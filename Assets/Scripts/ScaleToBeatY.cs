using UnityEngine;
using System.Collections;

public class ScaleToBeatY : MonoBehaviour{
	public int samples = 64;
	public int channel = 0;
	public int frequencyChannel = 32;
	public float amplitudeMultiplier = 1.0f;
	public FFTWindow window;

	private float originalObjectScale;
	
	// Use this for initialization
	void Start (){
		originalObjectScale = transform.localScale.y;
	}
	
	// Update is called once per frame
	void Update (){
		float[] data = new float[samples];
		AudioListener.GetSpectrumData (data, channel, window);
		Vector3 temp = transform.localScale;
		temp.y = originalObjectScale + data[frequencyChannel]*amplitudeMultiplier;
		transform.localScale = temp;
	}
}
