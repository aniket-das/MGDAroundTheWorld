﻿using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
				if (other.tag == "Player")
						Application.LoadLevel (2);
		}
}
