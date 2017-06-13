using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowForceX: MonoBehaviour {

	private LineRenderer lineRenderer;
	public Rigidbody cbClone;
	private Vector3 relative;

	void Start(){
		lineRenderer = GetComponent<LineRenderer> ();
		lineRenderer.SetWidth (.1f, .25f);
	}

	void Update() {
		relative = transform.InverseTransformDirection(Vector3.right)*cbClone.velocity.x;
		lineRenderer.SetPosition (0, relative);
	}
}
