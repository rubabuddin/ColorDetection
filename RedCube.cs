﻿using UnityEngine;
using System.Collections;

public class RedCube : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.renderer.material.color = Color.red;
	}
}
