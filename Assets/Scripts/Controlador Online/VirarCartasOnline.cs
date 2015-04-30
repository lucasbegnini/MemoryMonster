using UnityEngine;
using System.Collections;

public class VirarCartasOnline : MonoBehaviour {

	private GameObject [] _monster;
	private PhotonView myPhotonView;
	void OnEnable () {

		myPhotonView = gameObject.GetComponent<PhotonView>();
		this.myPhotonView.RPC ("VirarCartas", PhotonTargets.All);
	}
	[RPC]
	void VirarCartas()
	{
		_monster = GameObject.FindGameObjectsWithTag ("Monsters");
		for (int i = 0; i < _monster.Length ; i++) {
			_monster[i].RotateTo(new Vector3(0,180,0),2.0f,0.0f);
			_monster[i].GetComponent<BoxCollider>().enabled = true;
			
		}
	}
}
