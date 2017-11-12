﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestruction : MonoBehaviour {

	private GameObject destructionPoint;

	// Use this for initialization
	void Start () {
		destructionPoint = GameObject.Find ("DestructionPoint");
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < destructionPoint.transform.position.x) {
			Destroy (gameObject);
		}
	}
}
