﻿using UnityEngine;
using System.Collections;

public class GameWin : MonoBehaviour {

	
	void OnGUI()
	{
		GUI.Label (new Rect(Screen.width/2-40,50,80,30), "YOU WIN!!!!");

		if(GUI.Button (new Rect(Screen.width/2-30,350,60,30), "Retry?"))
		{
			Application.LoadLevel(0);
		}
	}
}