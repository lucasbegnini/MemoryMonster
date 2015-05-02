using UnityEngine;
using System.Collections;

public class WhoIsIt : MonoBehaviour {
	public static PhotonView ScenePhotonView;
	public static int playerWhoIsIt;
	private int count;

	private PhotonView myPhotonView;

	void Start()
	{
		ScenePhotonView = this.GetComponent<PhotonView> ();
	}

	public int WhoIs()
	{
		playerWhoIsIt = PhotonNetwork.player.ID;
		return playerWhoIsIt;
	}
	
}
