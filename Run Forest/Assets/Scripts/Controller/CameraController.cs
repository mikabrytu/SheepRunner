using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	private GameObject player;
	private float lastPlayerPosition;
	private float distance;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		lastPlayerPosition = playerPosition ();
	}
	
	// Update is called once per frame
	void Update () {
		distance = player.transform.position.x - lastPlayerPosition;
		transform.transform.position = new Vector3 (transform.position.x + distance, transform.position.y, transform.position.z);
		lastPlayerPosition = playerPosition ();
	}

	float playerPosition() {
		return player.transform.position.x;
	}
}
