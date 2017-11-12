using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	private PlayerController player;
	private Vector3 lastPlayerPosition;
	private float distance;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<PlayerController> ();
		NewPlayerPosition ();
	}
	
	// Update is called once per frame
	void Update () {
		distance = player.transform.position.x - lastPlayerPosition.x;
		transform.position = new Vector3 (transform.position.x + distance, transform.position.y, transform.position.z);
		NewPlayerPosition ();
	}

	void NewPlayerPosition() {
		lastPlayerPosition = player.transform.position;
	}
}
