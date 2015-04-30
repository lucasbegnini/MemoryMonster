using UnityEngine;
using System.Collections;

public class WhoIsIt : MonoBehaviour {
	public static PhotonView ScenePhotonView;
	public static int playerWhoIsIt;

	void Start()
	{
		ScenePhotonView = this.GetComponent<PhotonView> ();
	}

	void OnJoinedRoom()
	{
		// game logic: if this is the only player, we're "it"
		if (PhotonNetwork.playerList.Length == 1)
		{
			playerWhoIsIt = PhotonNetwork.player.ID;
		}
	}

	[RPC]
	void TaggedPlayer(int playerID)
	{
		playerWhoIsIt = playerID;
		Debug.Log("TaggedPlayer: " + playerID);
	}


 	void OnPhotonPlayerConnected (PhotonPlayer player)
	{
		Debug.Log ("OnPhotonPlayerConnected :" + player);


		if (PhotonNetwork.isMasterClient) {
			tagPlayer(playerWhoIsIt);
		}
	}

	public static void tagPlayer(int playerID)
	{
		Debug.Log("TagPlayer: " + playerID);
		ScenePhotonView.RPC("TaggedPlayer", PhotonTargets.All, playerID);
	}
}
