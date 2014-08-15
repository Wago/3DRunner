using UnityEngine;
using System.Collections;

public class ScaleToBeat : MonoBehaviour{
	public int samples = 64;
	public int channel = 0;
	public int frequencyChannel = 32;
	public float amplitudeMultiplier = 1.0f;
	public FFTWindow window;

	private float originalObjectScaleY;
	private float originalObjectScaleX;
	private float originalObjectScaleZ;
	
	// Use this for initialization
	void Start (){
		originalObjectScaleY = transform.localScale.y;
		originalObjectScaleX = transform.localScale.x;
		originalObjectScaleZ = transform.localScale.z;
	}
	
	// Update is called once per frame
	void Update (){
		float[] data = new float[samples];
		AudioListener.GetSpectrumData (data, channel, window);
		Vector3 temp = transform.localScale;
		temp.y = originalObjectScaleY + data[frequencyChannel]*amplitudeMultiplier;
		temp.x = originalObjectScaleX + data[frequencyChannel]*amplitudeMultiplier;
		temp.z = originalObjectScaleZ + data[frequencyChannel]*amplitudeMultiplier;
		transform.localScale = temp;
	}
}
