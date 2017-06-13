using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShootCannon : MonoBehaviour, IPointerClickHandler {
	
	public Rigidbody cannonball;
	public Rigidbody cbFollower;
	public Rigidbody cbFollowerTwo;
	public Transform shotSpawn;
	private float shootForce = 1;
	private string shootTemp;

	public void Update(){
		shootTemp = GameObject.Find ("ShootForceInput").GetComponent<InputField> ().text;
		shootForce = float.Parse (shootTemp);
	}

	public void OnPointerClick (PointerEventData data) {
		Rigidbody cannonB = (Rigidbody)Instantiate (cannonball, shotSpawn.position, shotSpawn.rotation);
		cannonB.AddForce (-shotSpawn.right*shootForce, ForceMode.Impulse);

		Rigidbody cbFollow = (Rigidbody)Instantiate (cbFollower, shotSpawn.position, shotSpawn.rotation);
		cbFollow.AddForce (-shotSpawn.right*shootForce, ForceMode.Impulse);

		Rigidbody cbFollowII = (Rigidbody)Instantiate (cbFollowerTwo, shotSpawn.position, shotSpawn.rotation);
		cbFollowII.AddForce (-shotSpawn.right*shootForce, ForceMode.Impulse);
	}
}