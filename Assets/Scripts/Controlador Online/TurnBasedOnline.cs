using UnityEngine;
using System.Collections;

public class TurnBasedOnline : MonoBehaviour {

	private GameObject [] _players;
	private int cont;
	private int Vez;
	private PhotonView myPhotonView;

	void Start()
	{
		cont = 0;
		Vez = 0;
	}

	void OnEnable () {
		StartCoroutine (VirarCartas ());

		myPhotonView = gameObject.GetComponent<PhotonView>();
		
		this.myPhotonView.RPC ("habilitarPraJogo", PhotonTargets.All,0 );
	}

	[RPC]
	void habilitarPraJogo(int player)
	{
		_players = GameObject.FindGameObjectsWithTag ("Player");
		//		Debug.Log (cont);
		if (player == 0) {
			Debug.Log("Vez do Player1");
			Vez = 0;
			_players[1].GetComponent<PossoJogarOnline> ().setOFF();
			_players[0].GetComponent<PossoJogarOnline> ().setON();
			
		}
		
		if (player == 1) {
			Debug.Log("Vez do Player2");
			Vez = 1;
			_players[0].GetComponent<PossoJogarOnline> ().setOFF();
			_players[1].GetComponent<PossoJogarOnline> ().setON();
		}
		
		
	}

	public int getVez()
	{
		return Vez;
	}
	
	IEnumerator VirarCartas()
	{
		gameObject.GetComponent<VirarCartasOnline> ().enabled = true;
		yield return new WaitForSeconds (1.0f);
		gameObject.GetComponent<VirarCartasOnline> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
