using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MucusController : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.right * Time.deltaTime * 5);	
	}
}
