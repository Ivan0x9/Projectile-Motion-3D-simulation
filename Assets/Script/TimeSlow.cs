using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class TimeSlow :MonoBehaviour , IPointerClickHandler {
	
	public void OnPointerClick(PointerEventData data){
		doPauseToggle();
	}
	
	void doPauseToggle(){
		if (Time.timeScale > 0.3f) {
			pauseGame();
		}
		else{
			unPauseGame();
		}
	}
	
	public void pauseGame(){
		Time.timeScale = 0.3f;
	}
	public void unPauseGame(){
		Time.timeScale = 1;
	}
}
