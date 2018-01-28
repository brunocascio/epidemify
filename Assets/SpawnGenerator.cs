using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGenerator : MonoBehaviour {
	private class Pair {
		private Pair(float a, float b)
		{
			izq=a;der=b;
		}
		float izq { get; set;}
		float der { get; set;}
	}
	private class Aristas {
		private Aristas(Pair p1, Pair p2)
		{
			abajo=p1;
			arriba=p2;
		}

		Pair abajo{ get; set; }
		Pair arriba{ get; set; }
	}
	List<Aristas> ListaZonas = new List<Aristas>();
	// Use this for initialization
	void Awake () {
		ListaZonas.Add(new Aristas(new Pair(,),new Pair(,));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
