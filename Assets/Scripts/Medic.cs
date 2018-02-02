using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medic : MonoBehaviour {

	public GameObject player;
	public GameObject people;
	public float chaseRange;

	void Update()  {  
		float distanceToTarget = Vector3.Distance (transform.position, player.transform.position);

		if (distanceToTarget < chaseRange)
		{
			Vector3 targetDir = player.transform.position - transform.position;
			float angle = Mathf.Atan2 (targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
			Quaternion q = Quaternion.AngleAxis (angle, Vector3.forward);
			transform.rotation = Quaternion.RotateTowards (transform.rotation, q, 180);
			transform.Translate (Vector3.up * Time.deltaTime * 3f);
		}
	}
}
