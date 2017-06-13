using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeMass : MonoBehaviour {

	private string cbMass;
	private float temp;
	private Rigidbody cbObject;

	// Use this for initialization
	void Start () {

	}
	// Update is called once per frame
	public void Update () {
		cbObject = (Rigidbody)Resources.Load ("prefabs/Cannoball", typeof(Rigidbody));
		cbMass = GameObject.Find ("CannonBallInput").GetComponent<InputField> ().text;
		temp = float.Parse(cbMass);
		cbObject.mass = temp;
	}
}
