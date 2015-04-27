using UnityEngine;
using System.Collections;

public class InstanciarPlayer : MonoBehaviour {


	public GameObject Player;
	public GameObject [] _players;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < _players.Length; i++) {
			_players[i] = GameObject.Instantiate(Player) as GameObject;
		}

		GetComponent<TurnedBase> ().enabled = true;
		GetComponent<ShwScore> ().enabled = true;
	}
	

}
