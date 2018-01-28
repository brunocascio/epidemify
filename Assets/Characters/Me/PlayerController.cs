using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	//Floating point variable to store the player's movement speed.
	public float speed;
	public GameObject bulletPrefab;
	public Transform bulletSpawn;

	//Store a reference to the Rigidbody2D component required to use 2D Physics.
	private Rigidbody2D playerRigidBody2D;

	// Use this for initialization
	void Start()
	{
		//Get and store a reference to the Rigidbody2D component so that we can access it.
		playerRigidBody2D = GetComponent<Rigidbody2D> ();
	}

	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Fire();
		}
	}

	void Fire()
	{
		// Create the Bullet from the Bullet Prefab
		var bullet = (GameObject)Instantiate(
			bulletPrefab,
			bulletSpawn.position,
			bulletSpawn.rotation);

		// Add velocity to the bullet
		bullet.GetComponent<Rigidbody2D>().velocity = bullet.transform.forward * 60;

		// Destroy the bullet after 2 seconds
		Destroy(bullet, 2.0f);        
	}

	//FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
	void FixedUpdate()
	{
		//Store the current horizontal input in the float moveHorizontal.
		float moveHorizontal = Input.GetAxis ("Horizontal");

		//Store the current vertical input in the float moveVertical.
		float moveVertical = Input.GetAxis ("Vertical");

		//Use the two store floats to create a new Vector2 variable movement.
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

		//Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
		playerRigidBody2D.AddForce (movement * speed);
	}
}
