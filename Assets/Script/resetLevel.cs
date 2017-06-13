using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class resetLevel :MonoBehaviour , IPointerClickHandler
{
	public void OnPointerClick(PointerEventData data)
	{
		// reload the scene
		Application.LoadLevelAsync(Application.loadedLevelName);
	}
}