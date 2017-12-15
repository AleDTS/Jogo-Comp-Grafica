using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkingTriggers : MonoBehaviour {

	private int enteredBy = 0;
	private bool alredyEntered = false;
	private Bounds tBounds;

	// Use this for initialization
	void Start () {
		tBounds = this.GetComponent<Collider> ().bounds;
		AudioListener.volume = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		
		RaycastHit hit;

		if (other.gameObject.tag == "Player") {
			if (Physics.Raycast(this.transform.position, this.transform.forward, out hit)){
				//Debug.Log("Point of contact: "+hit.point);
			}
			Bounds oBounds = other.gameObject.GetComponent<Collider> ().bounds;

			Debug.Log (this.transform.right);
			Debug.Log (other.gameObject.transform.right);
		}
	}

//	void OnTriggerExit(Collider other){
//
//		RaycastHit hit;
//
//		if (other.gameObject.tag == "Player") {
//			if (Physics.Raycast(this.transform.position, this.transform.forward, out hit)){
//				//Debug.Log("Point of contact: "+hit.point);
//			}
//			Bounds oBounds = other.gameObject.GetComponent<Collider> ().bounds;
//
//			Debug.Log (this.transform.right);
//			Debug.Log (other.gameObject.transform.right);
//		}
//	}
}
