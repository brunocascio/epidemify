using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonaEnferma : MonoBehaviour {

	private float tChange = 0f; // force new direction in the first Update
	private float randomX=0;
	private float randomY=0;
	private float randomVel;
	private float moveSpeed = 1f;
	// Use this for initialization

	private Rigidbody2D TheRigidBody;

	void Start () {
		TheRigidBody = this.GetComponent<Rigidbody2D> ();
	}

	void Update () {
		// change to random direction at random intervals
		if (Time.time >= tChange)
		{
			randomX = Random.Range(-1.0f,1.0f); // with float parameters, a random float
			randomY = Random.Range(-1.0f,1.0f); //  between -2.0 and 2.0 is returned
			randomVel = Random.Range(-1.0f, 1.0f);
			// set a random interval between 0.5 and 1.5
			tChange = Time.time + Random.Range(0.5f,1.5f);
			moveSpeed += randomVel;
		}
		Vector2 v = new Vector2 (randomX, randomY);
		TheRigidBody.velocity = v * moveSpeed;
			
	}
}
