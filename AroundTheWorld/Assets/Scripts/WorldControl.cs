﻿using UnityEngine;
using System.Collections;

public class WorldControl : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.back*Time.deltaTime*30);
	}
}
