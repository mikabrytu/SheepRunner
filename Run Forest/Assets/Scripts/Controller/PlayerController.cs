using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public LayerMask groundMask;
	public LayerMask deathMask;

	private Rigidbody2D playerBody;
	private Collider2D playerCollider;
	private bool grounded, dead;
	private float speed = 5;
	private float jumpForce = 30;
	private float aceleration = 0.003f;

	// Use this for initialization
	void Start () {
		playerBody = GetComponent<Rigidbody2D> ();
		playerCollider = GetComponent<Collider2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		grounded = Physics2D.IsTouchingLayers (playerCollider, groundMask);
		dead = Physics2D.IsTouchingLayers (playerCollider, deathMask);
		playerBody.velocity = new Vector2(speed, playerBody.velocity.y);

		/*if (dead) {
			// Stop game loop
			Time.timeScale = 0;
			print ("Game Over");

			// Restarting the game
			if (Input.GetKey (KeyCode.Space) || Input.GetMouseButtonDown (0)) {
				Application.LoadLevel (0);
				Time.timeScale = 1;
			}
		}*/
		
		if ((Input.GetKey (KeyCode.Space) || Input.GetMouseButtonDown (0)) && grounded) {
			playerBody.velocity = new Vector2 (playerBody.velocity.x, jumpForce);
		}

		speed += aceleration;
	}
}
