using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkingTriggers : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		//Physics.IgnoreCollision (other.gameObject.GetComponentInChildren<Collider>(), GetComponent < Collider>());
		if (other.gameObject.tag == "Player") {
			//Debug.Log ("to aqui");

			Debug.Log ("Faixaaaa");
		}
	}
}
