using UnityEngine;
using System.Collections;

public class VirarCartaOnline : MonoBehaviour {

	private Vector3 rotation;
	private GameObject [] _players;
	private int idPlayer;
	private int PhotonIdPlayer;

	private PhotonView myPhotonView;


	void Start()
	{
		rotation = new Vector3 (0, 0, 0);
		
	}
	void OnMouseDown()
	{
		myPhotonView = gameObject.GetComponent<PhotonView>();
		this.myPhotonView.RPC ("Vira", PhotonTargets.All);
	}


	[RPC]
	void Vira()
	{
	//	Debug.Log ("Virou o monstro :" + gameObject.name);
		_players = GameObject.FindGameObjectsWithTag ("Player");
		idPlayer = GameObject.FindGameObjectWithTag("GameController").GetComponent<TurnBasedOnline>().getVez();
		PhotonIdPlayer = PhotonNetwork.player.ID;
		PhotonIdPlayer = PhotonIdPlayer - 1;
		Debug.Log ("PhotonId: " + PhotonIdPlayer);
		Debug.Log ("Id: " + idPlayer);

		if ( ( _players [idPlayer].GetComponent<PossoJogarOnline> ().getPossoJogar () ) && (idPlayer == PhotonIdPlayer) )  
		{
			gameObject.RotateTo (rotation, 1.0f, 0.0f);
			gameObject.GetComponent<BoxCollider> ().enabled = false;

		} else {
			//Debug.Log("Nao e sua vez");
		}
	}




}
