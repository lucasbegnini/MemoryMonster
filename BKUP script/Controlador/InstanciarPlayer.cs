using UnityEngine;
using System.Collections;

public class InstanciarPlayer : MonoBehaviour {
	public GameObject Player;
	private GameObject _Player;
	// Use this for initialization
	void Start () {
		_Player = GameObject.Instantiate (Player) as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
