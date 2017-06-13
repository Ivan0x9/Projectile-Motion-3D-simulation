using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {

	public float moveSpeed = 1.0f;
	public Vector2 xCon;
	public Vector2 yCon;
	Vector2 changePos;
	
	private float minFOV = 15f;
	private float maxFOV = 90f;
	private float sensitivity = 10f;
	private float FOV;
	
	void Update () 
	{
		changePos += new Vector2(Input.GetAxis("Horizontal") * moveSpeed, Input.GetAxis("Vertical") * moveSpeed);
		transform.localPosition = new Vector3(Mathf.Clamp(changePos.x, xCon.x, xCon.y), Mathf.Clamp(changePos.y, yCon.x, yCon.y), transform.position.z);
		
		if(changePos.x < xCon.x)
		{
			changePos = new Vector2(xCon.x, changePos.y);
		}
		if(changePos.x > xCon.y)
		{
			changePos = new Vector2(xCon.y, changePos.y);
		}
		if(changePos.y < yCon.x)
		{
			changePos = new Vector2(changePos.x, yCon.x);
		}
		if(changePos.y > yCon.y)
		{
			changePos = new Vector2(changePos.x, yCon.y);
		}

		FOV = Camera.main.fieldOfView;
		FOV += Input.GetAxis("Mouse ScrollWheel") * sensitivity;
		FOV = Mathf.Clamp (FOV, minFOV, maxFOV);
		Camera.main.fieldOfView = FOV;
	}
}
