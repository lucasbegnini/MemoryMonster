using UnityEngine;
using System.Collections;

public class PlayerId : MonoBehaviour {

	private GameObject [] _players;
	private int idPlayer;

	private PhotonView myPhotonView;

	void OnMouseDown()
	{
		myPhotonView = gameObject.GetComponent<PhotonView>();
		if (Application.loadedLevelName.Equals ("Online")) {
			this.myPhotonView.RPC ("setIdPlayer", PhotonTargets.All);
		}

	}

	[RPC]
	void setIdPlayer()
	{
		if (!this.enabled)
		{
			return;
		}
		
		_players = GameObject.FindGameObjectsWithTag ("Player");
		idPlayer = GameObject.FindGameObjectWithTag("GameController").GetComponent<TurnBasedOnline>().getVez();
	}



	void OnApplicationFocus(bool focus)
	{
		this.enabled = focus;
	}

}
