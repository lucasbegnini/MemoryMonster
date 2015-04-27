using UnityEngine;
using System.Collections;

public class NovaRodada : MonoBehaviour {

	private GameObject [] _monster;

	// Use this for initialization
	void OnEnable () {
		_monster = GameObject.FindGameObjectsWithTag ("Monsters");
		VirarCartas ();
		StartCoroutine (espera ());

	}

 IEnumerator espera()
	{ 
		yield return new WaitForSeconds (1.0f);
		GameObject.FindGameObjectWithTag ("Player").GetComponent<EscolherCartas> ().enabled = true;
		GameObject.FindGameObjectWithTag ("Player").GetComponent<PossoJogar> ().setPossoJogar (true);
		gameObject.GetComponent<NovaRodada> ().enabled = false;
	}
	void VirarCartas()
	{
		for (int i = 0; i < _monster.Length ; i++) {
			_monster[i].RotateTo(new Vector3(0,180,0),2.0f,0.0f);
			
		}
	}

}
