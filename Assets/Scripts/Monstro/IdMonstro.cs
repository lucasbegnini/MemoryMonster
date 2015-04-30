using UnityEngine;
using System.Collections;

public class IdMonstro : MonoBehaviour {

	public int ID;
	private GameObject [] _players;
	private int idPlayer;

	void Start()
	{	}

	void OnMouseDown()
	{
		setIdPlayer ();
		if(_players[idPlayer].GetComponent<PossoJogar>().getPossoJogar())
		{
			_players[idPlayer].GetComponent<EscolherCartas> ().MonstroEscolhido (ID);
		}
	}

	void setIdPlayer()
	{
		_players = GameObject.FindGameObjectsWithTag ("Player");
		GameObject.FindGameObjectWithTag ("GameController").GetComponent<TurnedBase> ().getVez ();
	}


	public void DestruiMonsters(int entrada)
	{
		if (ID == entrada) {
			StartCoroutine(Destruir());
		}
	}

	IEnumerator Destruir()
	{
		yield return new WaitForSeconds(2.0f);
		gameObject.SetActive (false);
	}
}
