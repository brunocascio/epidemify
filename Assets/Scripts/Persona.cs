using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persona : MonoBehaviour {
	public Sprite sickSprite;
	public bool sick = false;

	public bool isSick()
	{
		return sick;
	}

	public void sickPerson()
	{
		transform.GetComponent<SpriteRenderer> ().sprite = sickSprite;
		transform.position = new Vector3 (transform.position.x, transform.position.y, -1);
		sick = true;
	}
}
