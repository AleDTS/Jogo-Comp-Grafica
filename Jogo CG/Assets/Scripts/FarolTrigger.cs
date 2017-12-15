using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarolTrigger : MonoBehaviour {

	private Bounds tbounds;
	private bool passou = false;
	public GameObject game;

	// Use this for initialization
	void Start () {
		game = GameObject.Find ("UI");
		tbounds = this.GetComponent<Collider> ().bounds;
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerStay(Collider other){
		if (other.gameObject.tag == "Player") {
			if (tbounds.Contains (other.gameObject.GetComponent<Collider> ().bounds.center) && !passou) {
				game.GetComponent<GameController> ().Perdeu (5);
				passou = true;
			}
		}
	}

	void OnTriggerExit(Collider other){
		if (other.gameObject.tag == "Player")
			passou = false;
	}
}
