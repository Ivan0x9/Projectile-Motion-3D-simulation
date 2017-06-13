using UnityEngine;
using System.Collections;

public class rotateCannon : MonoBehaviour {

	public float speed;
	public float larpSpeed;
	private float yDeg;
	private Quaternion fromRotation;
	private Quaternion toRotation;

	public void Update () {
		if(Input.GetMouseButton(1))
		{
			yDeg -= Input.GetAxis("Mouse Y")*speed;
			yDeg = Mathf.Clamp (yDeg, -95, 15);
			fromRotation = transform.rotation;
			toRotation = Quaternion.Euler(0,0,yDeg);
			transform.rotation = Quaternion.Lerp(fromRotation, toRotation, Time.deltaTime * speed);
		}
	}
}
