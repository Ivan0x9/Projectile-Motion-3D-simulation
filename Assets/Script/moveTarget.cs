using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class moveTarget : MonoBehaviour {

	private GameObject target;
	private float HandlerPos;

	public void Start(){
		target = GameObject.Find("GroundTarget");
	}

	public void Update(){
			HandlerPos = GameObject.Find ("MoveTargetSlider").GetComponent<Slider> ().value;
			Vector3 temp = target.transform.position;
			temp.x = HandlerPos;
			target.transform.position = -temp;
	}

}