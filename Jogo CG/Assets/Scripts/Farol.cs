using UnityEngine;
using System.Collections;

public class Farol : MonoBehaviour {
	public GameObject vermelho, verde, amarelo,trigger;
	public float tempo_vermelho,tempo_verde, tempo_amarelo,tempo;
	public Material cor;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (tempo < tempo_verde) {
			tempo += Time.deltaTime;
		} else {
			tempo = 0;
		}

		if (tempo < tempo_vermelho) {
			vermelho.GetComponent<Renderer> ().material.EnableKeyword ("_EMISSION");
			amarelo.GetComponent<Renderer> ().material.DisableKeyword ("_EMISSION");
			verde.GetComponent<Renderer> ().material.DisableKeyword ("_EMISSION");
			trigger.SetActive (true);
		}
		if (tempo > tempo_vermelho && tempo < tempo_amarelo) {
			vermelho.GetComponent<Renderer> ().material.DisableKeyword ("_EMISSION");
			amarelo.GetComponent<Renderer> ().material.DisableKeyword ("_EMISSION");
			verde.GetComponent<Renderer> ().material.EnableKeyword ("_EMISSION");
			trigger.SetActive (false);
		}
		if (tempo > tempo_amarelo) {
			vermelho.GetComponent<Renderer> ().material.DisableKeyword ("_EMISSION");
			amarelo.GetComponent<Renderer> ().material.EnableKeyword ("_EMISSION");
			verde.GetComponent<Renderer> ().material.DisableKeyword ("_EMISSION");
			trigger.SetActive (true);
		}
	}
}
