using UnityEngine;
using System.Collections;

public class PossoJogarOnline : MonoBehaviour {

	private PhotonView myPhotonView;
	private bool _PossoJogar;
	// Use this for initialization

	public void setON()
	{
		_PossoJogar = true;
		myPhotonView = gameObject.GetComponent<PhotonView>();
		this.myPhotonView.RPC ("setarONRPC", PhotonTargets.All);
	}

	public void setOFF()
	{
		_PossoJogar = false;
		myPhotonView = gameObject.GetComponent<PhotonView>();
		this.myPhotonView.RPC ("setarOFFRPC", PhotonTargets.All);
	}

	[RPC]
	void setarONRPC()
	{
		gameObject.GetComponent<EscolherCartas>().enabled = true;
	}

	[RPC]
	void setarOFFRPC()
	{
		gameObject.GetComponent<EscolherCartas>().enabled = false;
	}
	public bool getPossoJogar()
	{return _PossoJogar;	}
}
