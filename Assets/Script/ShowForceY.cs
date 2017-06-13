using UnityEngine;
using System.Collections;

public class ShowForceY: MonoBehaviour {

	private LineRenderer lineRenderer;
	public Rigidbody cbFollower;
	private Vector3 relative;	

	void Start(){
		lineRenderer = GetComponent<LineRenderer> ();
		lineRenderer.SetWidth (.1f, .25f);
	}
	
	void Update() {
		relative = transform.InverseTransformDirection (Vector3.up)*(cbFollower.velocity.y);
		lineRenderer.SetPosition (0, relative);
	}
}
