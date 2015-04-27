using UnityEngine;
using System.Collections;

public class DestruirMonstros : MonoBehaviour {

	GameObject [] _monsters;
	// Use this for initialization
	void Start () {
	
		_monsters = GameObject.FindGameObjectsWithTag ("Monster");
	}
	
	public void procuraMonstrosDestruir(int id)
	{
		for (int i = 0; i < _monsters.Length ; i++)
		{
			if(_monsters[i].GetComponent<Monster>().getId().Equals(id))
				Destroy(_monsters[i]);
		}
	}
}
