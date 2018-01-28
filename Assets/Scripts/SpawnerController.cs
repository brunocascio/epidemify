using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour {

	public GameObject personaSana;
	public int maxPeople = 4;
	public GameObject medic;
	
	// Update is called once per frame
	void Awake () {
		spawnPeople ();
		InvokeRepeating ("spawnMedics", 0f, Random.Range(20f, 30f));
	}

	void spawnPeople()
	{
		for (int i = 1; i <= maxPeople; i++) 
		{
			Instantiate (personaSana, transform.position, transform.rotation);
		}
	}


	void spawnMedics()
	{
		Instantiate (medic, transform.position, transform.rotation);
	}
}
