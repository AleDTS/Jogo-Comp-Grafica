using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody rgbdy;
	private Bounds tbounds;
	public GameObject game;
	private GameObject spot;
	private GameObject pointer;
	public bool bateu = false;
	public bool wait = false;

	// Use this for initialization
	void Start () {
		spot = GameObject.Find ("parking_spot");
		pointer = GameObject.Find ("pointer_parent");
		//gameObject = GameObject.Find ("GameController");
		rgbdy = this.GetComponent<Rigidbody> ();
		tbounds = this.GetComponent<Collider> ().bounds;
		//AudioListener.volume = 0f;
	}

	// Update is called once per frame
	void Update () {
		//pointer.transform.Rotate (Vector3.RotateTowards(this.transform.position, spot.transform.position,0f, 0f));
	}

	void OnCollisionEnter(Collision other){
			if (!bateu) {
				game.GetComponent<GameController> ().Perdeu (4);
				wait = true;
			}
	}

	void OnCollisionExit(Collision other){
		
			bateu = true;
			if (wait)
				StartCoroutine (Wait());
	}

	public float Velocity(){
		return rgbdy.velocity.magnitude*3.6f;
	}

	IEnumerator Wait(){
		wait = false;
		yield return new WaitForSeconds (1.5f);
		bateu = false;
	}
}
