using UnityEngine;
using System.Collections;

public class ShwScore : MonoBehaviour {

	public TextMesh p1;
	public TextMesh p2;
	private GameObject [] _players;

	void OnEnable()
	{
		_players = GameObject.FindGameObjectsWithTag ("Player");
	}

	void Update()
	{
		p1.text = "Player 1: " + _players [0].GetComponent<Score> ().getScore().ToString();
		p2.text = "Player 2: " + _players [1].GetComponent<Score> ().getScore().ToString();
	}
}
