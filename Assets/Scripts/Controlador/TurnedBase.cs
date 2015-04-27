using UnityEngine;
using System.Collections;

public class TurnedBase : MonoBehaviour {

	private GameObject [] _players;
	private int cont;
	private int Vez;

	void Start()
	{
		cont = 0;
		Vez = 0;
	}
	// Use this for initialization
	void OnEnable () {
		StartCoroutine (VirarCartas ());
		_players = GameObject.FindGameObjectsWithTag ("Player");
		habilitarPraJogo ();
	}

	void habilitarPraJogo()
	{
		cont++;
//		Debug.Log (cont);
		if (cont == 1) {
			Debug.Log("Vez do Player1");
			Vez = 0;
			_players[1].GetComponent<EscolherCartas>().enabled = false;
			_players[1].GetComponent<PossoJogar> ().setPossoJogar (false);
			_players[0].GetComponent<EscolherCartas>().enabled = true;
			_players[0].GetComponent<PossoJogar> ().setPossoJogar (true);

		}

		if (cont == 2) {
			Debug.Log("Vez do Player2");
			Vez = 1;
			_players[0].GetComponent<EscolherCartas>().enabled = false;
			_players[0].GetComponent<PossoJogar> ().setPossoJogar (false);
			_players[1].GetComponent<EscolherCartas>().enabled = true;
			_players[1].GetComponent<PossoJogar> ().setPossoJogar (true);
			cont = 0;
		}
	
	
	}

	public int getVez()
	{
		return Vez;
	}

	IEnumerator VirarCartas()
	{
		gameObject.GetComponent<VirarCartas> ().enabled = true;
		yield return new WaitForSeconds (1.0f);
		gameObject.GetComponent<VirarCartas> ().enabled = false;
	}
}
