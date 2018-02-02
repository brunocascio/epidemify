using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	
	public float speed;
	public GameObject mucusPrefab;

	private Animator animator;
	private Transform nosePoint;
	private Rigidbody2D playerRigidBody;

	// Use this for initialization
	void Awake()
	{
		playerRigidBody = transform.GetComponent<Rigidbody2D> ();
		animator = transform.GetComponent<Animator> ();
		nosePoint = transform.Find("nosePoint");
	}

	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Sneeze();
		}
	}

	void Sneeze()
	{
		Vector2 mousePosition = new Vector2 (
			Camera.main.ScreenToWorldPoint(Input.mousePosition).x,
			Camera.main.ScreenToWorldPoint(Input.mousePosition).y
		);

		Instantiate (mucusPrefab, nosePoint.position, nosePoint.rotation);
	}

	//FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
	void FixedUpdate()
	{
		//Store the current horizontal input in the float moveHorizontal.
		float moveHorizontal = Input.GetAxis ("Horizontal");

		animator.SetFloat ("Horizontal", moveHorizontal);

		//Store the current vertical input in the float moveVertical.
		float moveVertical = Input.GetAxis ("Vertical");

		animator.SetFloat ("Vertical", moveVertical);

		//Use the two store floats to create a new Vector2 variable movement.
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

		//Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
		playerRigidBody.AddForce (movement * speed);
	}
}
