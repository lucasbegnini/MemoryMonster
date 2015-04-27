using UnityEngine;
using System.Collections;

public class VirarCartas : MonoBehaviour {

	private GameObject [] _monster;
	void OnEnable () {
		_monster = GameObject.FindGameObjectsWithTag ("Monsters");
		Virar ();
	}

	void Virar()
	{
		for (int i = 0; i < _monster.Length ; i++) {
			_monster[i].RotateTo(new Vector3(0,180,0),2.0f,0.0f);
			_monster[i].GetComponent<BoxCollider>().enabled = true;
			
		}
	}
}
