using UnityEngine;
using System.Collections;

public class InstanciarControle : MonoBehaviour {

	public GameObject Controle;
	void OnJoinedRoom()
	{
		if (PhotonNetwork.playerList.Length == 1) {
			instanciarControle ();
		}
	}
	void instanciarControle()
	{
		PhotonNetwork.Instantiate(Controle.name,Vector3.zero,Controle.transform.rotation,0);
	}
}
