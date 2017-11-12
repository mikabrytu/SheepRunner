using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundGenerator : MonoBehaviour {

	public GameObject ground;
	public Transform generatorPoint;

	private float groundWidth;

	// Use this for initialization
	void Start () {
		groundWidth = ground.GetComponent<BoxCollider2D> ().size.x;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < generatorPoint.position.x) {
			// Instantiate ground
			Vector3 groundPosition = new Vector3 (transform.position.x, ground.transform.position.y, ground.transform.position.z);
			Instantiate (ground, groundPosition, transform.rotation);

			transform.position = new Vector3 (transform.position.x + groundWidth, transform.position.y, transform.position.z);
		}
	}
}
