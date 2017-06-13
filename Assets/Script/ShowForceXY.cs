using UnityEngine;
using System.Collections;

public class ShowForceXY : MonoBehaviour {

	private LineRenderer lineRenderer;
	public Rigidbody cbFollower;
	private Vector3 relative;

	void Start () {
		lineRenderer = GetComponent<LineRenderer> ();
		lineRenderer.SetWidth (.1f, .5f);
	}

	void Update () {
		relative = transform.InverseTransformDirection(cbFollower.velocity)/1.4f;
		lineRenderer.SetPosition (0, relative);
	}
}
