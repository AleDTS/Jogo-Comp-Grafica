using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

	public GameObject prefab;
	public GameObject[] whereToSpawn;

	// Use this for initialization
	void Awake () {
		whereToSpawn = GameObject.FindGameObjectsWithTag("Spawn");


		int i = (int)Random.Range (0f,whereToSpawn.Length);
		Debug.Log (i);
		GameObject item = Instantiate (prefab, whereToSpawn[i].transform.position, Quaternion.identity);


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
