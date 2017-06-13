using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class TimeBending :MonoBehaviour , IPointerClickHandler {

	public void OnPointerClick(PointerEventData data){
			doPauseToggle();
	}

	void doPauseToggle(){
		if (Time.timeScale > 0) {
			pauseGame();
		}
		else{
			unPauseGame();
		}
	}

	public void pauseGame(){
		Time.timeScale = 0;
	}
	public void unPauseGame(){
		Time.timeScale = 1;
	}
}
