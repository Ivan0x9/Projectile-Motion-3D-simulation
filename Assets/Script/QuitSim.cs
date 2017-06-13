using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class QuitSim : MonoBehaviour, IPointerClickHandler {
	
	public void OnPointerClick(PointerEventData data) {
		Application.Quit ();
	}
}
