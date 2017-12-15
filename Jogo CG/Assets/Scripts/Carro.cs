using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class Carro : MonoBehaviour {

	public Transform[] pontos;
	public int contPontos;
	public NavMeshAgent nav;
	public float velocidadeNormal,distancia;
	public GameObject ignore;

	// Use this for initialization
	void Start () {
		nav = GetComponent<NavMeshAgent> ();
	}
	void OnCollisionEnter (Collision  collision) {
	 
	    if (collision.gameObject.tag == "theobjectToIgnore") {
	    	Physics.IgnoreCollision(nav.GetComponent<Collider>(), GetComponent<Collider>());
	       }
	 
	}
	// Update is called once per frame
	void Update () {
		nav.SetDestination (pontos [contPontos].position);
		distancia = Vector3.Distance (transform.position, pontos [contPontos].position);
		if (distancia < 1) {
			contPontos++;
		}
		if (Physics.Raycast (transform.position, transform.forward, 8)) {
			nav.speed = 0;
		} else {
			nav.speed = velocidadeNormal;
		}
		if (contPontos == pontos.Length) {
			contPontos = 0;
		}
	}
}
