using UnityEngine;
using System.Collections;


public class ShowForces : MonoBehaviour {
	
	private Vector3 moveDirection;
	GUIText kphDisplay;

	void Start(){
	}

	void Update() {
		double fwdSpeed = (moveDirection * Time.deltaTime).magnitude;
		kphDisplay.text = fwdSpeed.ToString ();
	}
}
