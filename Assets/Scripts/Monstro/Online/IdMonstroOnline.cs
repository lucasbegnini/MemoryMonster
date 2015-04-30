using UnityEngine;
using System.Collections;

public class IdMonstroOnline : MonoBehaviour {

	public int ID;
	private GameObject [] _players;
	private int idPlayer;
	
	private PhotonView myPhotonView;


	void OnMouseDown()
	{
		myPhotonView = gameObject.GetComponent<PhotonView>();
		setIdPlayer ();
		if(( _players [idPlayer].GetComponent<PossoJogarOnline> ().getPossoJogar () ) && (idPlayer.Equals(PhotonNetwork.player.ID-1) ) )
		{
			_players[idPlayer].GetComponent<EscolherCartas> ().MonstroEscolhido (ID);
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
