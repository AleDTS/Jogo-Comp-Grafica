
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public int pontos;
	public int velocidade;
	public TextMesh pts;
	public TextMesh speed;
	public TextMesh win;
	public GameObject player;

	private bool passou = false;
	private bool wait = false;
	private bool gameover = false;

	// Use this for initialization
	void Start () {
		pontos = 21;
	}

	// Update is called once per frame
	void Update () {
		if (pontos <= 0)
			GameOver ();
		velocidade = ((int)player.GetComponent<PlayerController> ().Velocity ());
		if (velocidade > 60) {
			
			if (!passou) {
				passou = true;
				Perdeu (5);
				if (!wait)
					StartCoroutine (Wait ());
			}
		}

		Atualiza ();
}

	void Atualiza(){

		pts.text = pontos.ToString();
		speed.text = velocidade.ToString();
	}

	public void Perdeu(int pt){
		if (gameover)
			return;
		pontos -= pt;
	}

	public void GameOver(){
		gameover = true;
		//Debug.Log ("GameOver!");
		Scene sc = SceneManager.GetActiveScene();
		SceneManager.LoadScene (sc.name);

//		Application.load
	}

	IEnumerator Wait(){
		wait = false;
		yield return new WaitForSeconds (5f);
		passou = false;
		win.text = "";
	}

	public void Win(){
		Debug.Log ("win!");
		win.text = "VOCE VENCEU!";
		StartCoroutine(Wait ());
		gameover = true;
	}
		
}