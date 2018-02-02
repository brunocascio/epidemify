using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MucusController : MonoBehaviour {
	
	private AudioSource fireSound;
	private AudioSource hitSound;

	void Awake()
	{
		AudioSource[] sounds = transform.GetComponents<AudioSource> ();
		fireSound = sounds [0];
		hitSound = sounds [1];
	}

	void Start()
	{
		fireSound.Play ();
		Destroy (gameObject, 0.35f);
	}

	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.right * Time.deltaTime * 10);	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		GameObject obj = other.gameObject;

		if (!obj.CompareTag("Player"))
		{
			if (obj.CompareTag ("Persona")) {
				Persona persona = obj.GetComponent<Persona> ();
				if (!persona.isSick ()) {
					persona.sickPerson ();
				}
				hitSound.Play ();
			} 
			else {
				Destroy (gameObject);
			}
		}
	}
}
