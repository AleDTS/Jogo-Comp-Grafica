using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour {

	private GameObject spot;
	private GameObject player;


	// Use this for initialization
	void Start () {
		spot = GameObject.Find ("parking_spot 1(Clone)");
		player = GameObject.Find ("Car");
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.DrawLine (spot.transform.position,player.transform.position);
		Vector3 targetDir = spot.transform.position - player.transform.position;
		float step = 1f * Time.deltaTime;
		Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0F);
		Debug.DrawRay(player.transform.position, newDir, Color.red);
		transform.rotation = Quaternion.LookRotation(new Vector3(newDir.x,newDir.z,newDir.y));
	}
}
