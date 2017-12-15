using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parking : MonoBehaviour {

	private Bounds tbounds;
	private bool parked = false;

	// Use this for initialization
	void Start () {
		tbounds = this.GetComponent<Collider> ().bounds;
		AudioListener.volume = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay(Collider other){
		//Physics.IgnoreCollision (other.gameObject.GetComponentInChildren<Collider>(), GetComponent < Collider>());
		if (other.gameObject.tag == "Player") {
			//Debug.Log ("to aqui");

			Bounds obounds = other.gameObject.GetComponent<Collider> ().bounds;

			if (tbounds.Contains (obounds.max) &
			    tbounds.Contains (obounds.min) & !parked) {
				Debug.Log ("Dentro");
				StartCoroutine (Wait ());
			}
		}
	}

	IEnumerator Wait(){
		yield return new WaitForSeconds (1.5f);
		Debug.Log ("Estacionou");
		parked = true;
	}
}
