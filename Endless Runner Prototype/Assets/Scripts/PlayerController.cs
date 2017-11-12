using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;
	public float jumpForce;
	public LayerMask groundLayer;

	private bool grounded;
	private Rigidbody2D playerBody;
	private Collider2D playerCollider;

	// Use this for initialization
	void Start () {
		playerBody = GetComponent<Rigidbody2D> ();
		playerCollider = GetComponent<Collider2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		grounded = Physics2D.IsTouchingLayers (playerCollider, groundLayer);
		playerBody.velocity = new Vector2 (speed, playerBody.velocity.y);

		if ((Input.GetKey(KeyCode.Space) || Input.GetMouseButtonDown(0)) && grounded) {
			playerBody.velocity = new Vector2(playerBody.velocity.x, jumpForce);
		}
	}
}
