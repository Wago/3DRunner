using UnityEngine;
using System.Collections;

public class PointsOTrigger : MonoBehaviour {

	public float Increase = 1;
	void OnTriggerEnter(){
		GameManager.Instance.pointsPerUnitTravelled += Increase;
	}
}
