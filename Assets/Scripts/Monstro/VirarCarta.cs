using UnityEngine;
using System.Collections;

public class VirarCarta : MonoBehaviour {

	private Vector3 rotation;
	private GameObject [] _players;
	private int idPlayer;
	void Start()
	{
		rotation = new Vector3 (0, 0, 0);
		_players = GameObject.FindGameObjectsWithTag ("Player");
	}
	void OnMouseDown()
	{
		setIdPlayer ();
		if(_players[idPlayer].GetComponent<PossoJogar>().getPossoJogar())
		{
		gameObject.RotateTo (rotation, 1.0f, 0.0f);
			gameObject.GetComponent<BoxCollider>().enabled = false;
		}
	}

	void setIdPlayer()
	{
		idPlayer = GameObject.FindGameObjectWithTag("GameController").GetComponent<TurnedBase>().getVez();
	}

}
