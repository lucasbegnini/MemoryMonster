using UnityEngine;
using System.Collections;

public class VirarCartaOnline : MonoBehaviour {

	private Vector3 rotation;
	private GameObject [] _players;
	private int idPlayer;
	private int idPlayerPhoton;


	private PhotonView myPhotonView;


	void Start()
	{
		rotation = new Vector3 (0, 0, 0);
		
	}
	void OnMouseDown()
	{
		myPhotonView = gameObject.GetComponent<PhotonView>();
		_players = GameObject.FindGameObjectsWithTag ("Player");
		idPlayer = GameObject.FindGameObjectWithTag("GameController").GetComponent<TurnBasedOnline>().getVez();
		idPlayerPhoton = _players [0].GetComponent<PhotonView>().ownerId;


		//Debug.Log (idPlayer);

		if ( idPlayer.Equals(idPlayerPhoton) ) {
			this.myPhotonView.RPC ("Vira", PhotonTargets.All);
		} else {
			Debug.Log("Nao e sua vez");
		}
	}


	[RPC]
	void Vira()
	{
			gameObject.RotateTo (rotation, 1.0f, 0.0f);
			gameObject.GetComponent<BoxCollider> ().enabled = false;
	}




}
