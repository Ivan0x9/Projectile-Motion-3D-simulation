using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class rotateCannonNr2 : MonoBehaviour {

	private float RotationA;
	private	GameObject myObject;

	// Use this for initialization
	void Start () {
		myObject = GameObject.Find ("CannonRear");
	}
	
	// Update is called once per frame
	public void RotateA() {
		RotationA = GameObject.Find ("RotateSlider").GetComponent<Slider> ().value;
		myObject.transform.localEulerAngles = new Vector3 (0, 0, -RotationA);
	}
}
