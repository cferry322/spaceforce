﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * -12.5f;
		var z = Input.GetAxis("Vertical") * Time.deltaTime * 12.5f;
	
		transform.Translate (z,x,0);
		//transform.Translate (z,0,0);
		//transform.Translate (0, 0, z);

		//transform.Rotate(0, x, 0);
		//transform.Translate(0, 0, z);
		
	}
}