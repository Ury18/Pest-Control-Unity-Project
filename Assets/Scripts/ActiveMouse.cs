﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveMouse : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
	}
}
