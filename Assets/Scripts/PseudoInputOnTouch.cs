using UnityEngine;
using System.Collections;

public class PseudoInputOnTouch : MonoBehaviour {

	public enum PseudoInputDirection { left, right }
	public PseudoInputDirection direction;

	void Touched(){
		if(direction == PseudoInputDirection.left){
			PseudoInput.Instance.leftPressed = true;
		}

		if(direction == PseudoInputDirection.right){
			PseudoInput.Instance.rightPressed = true;
		}
	}
}
