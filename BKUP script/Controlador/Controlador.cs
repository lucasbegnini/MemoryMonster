using UnityEngine;
using System.Collections;

public class Controlador : MonoBehaviour {

	private GameObject _Player;
	// Use this for initialization
	void Start () {
		_Player = GameObject.FindGameObjectWithTag("Player");
	}

	void PlayTheGame()
	{
		_Player.GetComponent<Player> ().setPossoJogar (true);
		_Player.GetComponent<Player> ().cleanEscolhidas();

	}

	public void PlayerAcertou(int idMonster)
	{
		_Player.GetComponent<Player> ().pontuar ();
		gameObject.GetComponent<DestruirMonstros>().procuraMonstrosDestruir (idMonster);
		PlayTheGame ();
	}

	public void PlayerErrou()
	{
		PlayTheGame ();
	}


}
