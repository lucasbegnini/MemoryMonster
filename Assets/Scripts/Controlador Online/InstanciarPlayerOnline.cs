using UnityEngine;
using System.Collections;

public class InstanciarPlayerOnline : MonoBehaviour {

	public GameObject Player;

	// Use this for initialization
	void OnJoinedRoom () {
	GameObject _player = PhotonNetwork.Instantiate (Player.name, Player.transform.position, Player.transform.rotation, 0);
		Score _score = _player.GetComponent<Score> ();
		_score.enabled = true;
		CheckEscolhasOnline _check = _player.GetComponent<CheckEscolhasOnline> ();
		_check.enabled = true;
		PossoJogarOnline _posso = _player.GetComponent<PossoJogarOnline> ();
		_posso.enabled = true;
		EscolherCartas _escolha = _player.GetComponent<EscolherCartas> ();
		_escolha.enabled = false;


		if(PhotonNetwork.playerList.Length == 2)
		{
			StartCoroutine(espera());
			//GameObject.FindGameObjectWithTag("GameController").GetComponent<ShwScore> ().enabled = true;
		}
	
	}
	IEnumerator espera()
	{
		yield return new WaitForSeconds (2.0f);
		GameObject.FindGameObjectWithTag("GameController").GetComponent<TurnBasedOnline> ().enabled = true;

	}

}
