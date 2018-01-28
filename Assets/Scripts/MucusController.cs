using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MucusController : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.right * Time.deltaTime * 5);	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("PersonaSana") || other.gameObject.CompareTag("Pared"))
		{
			Destroy (gameObject);
		}
	}
}
