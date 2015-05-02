using UnityEngine;
using System.Collections;

public class IdMonstroOnline : MonoBehaviour {

	public int ID;
	private GameObject [] _players;
	private int idPlayer;
	private int idPlayerPhoton;
	
	private PhotonView myPhotonView;


	void OnMouseDown()
	{

		setIdPlayer ();

		myPhotonView = gameObject.GetComponent<PhotonView>();
		_players = GameObject.FindGameObjectsWithTag ("Player");
		idPlayer = GameObject.FindGameObjectWithTag("GameController").GetComponent<TurnBasedOnline>().getVez();
		idPlayerPhoton = _players [0].GetComponent<PhotonView>().ownerId;
		if(idPlayer.Equals(idPlayerPhoton) )
		{
			_players[idPlayer-1].GetComponent<EscolherCartas> ().MonstroEscolhido (ID);
		}
	}
	
	void setIdPlayer()
	{
		_players = GameObject.FindGameObjectsWithTag ("Player");
		idPlayer = GameObject.FindGameObjectWithTag("GameController").GetComponent<TurnBasedOnline>().getVez();
	}
	
	
	public void DestruiMonsters(int entrada)
	{
		if (ID == entrada) {
			this.myPhotonView.RPC ("DestruiMonstroCerto", PhotonTargets.All);
		}
	}

	[RPC]
	void DestruiMonstroCerto()
	{
		StartCoroutine(Destruir());
	}
	
	IEnumerator Destruir()
	{
		yield return new WaitForSeconds(2.0f);
		gameObject.SetActive (false);
	}
}
