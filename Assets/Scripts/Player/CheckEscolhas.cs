using UnityEngine;
using System.Collections;

public class CheckEscolhas : MonoBehaviour {

	private GameObject [] _monster;

	void Start () {
		_monster = GameObject.FindGameObjectsWithTag ("Monsters");
		//GameObject.FindGameObjectWithTag ("GameController").GetComponent<TurnedBase> ().enabled = false;
	}


	public void check(int a, int b)
	{
		if (a.Equals (b)) {
			this.gameObject.GetComponent<Score>().setScore();
			ChecktoDestroy(a);

		} else {
//			Debug.Log ("Errou");
		}

		FimdaRodada ();
	}

	void FimdaRodada()
	{
		gameObject.GetComponent<EscolherCartas> ().enabled = false;
		gameObject.GetComponent<PossoJogar> ().setPossoJogar (false);
		StartCoroutine (AtivarFimRodada ());
	}

	IEnumerator AtivarFimRodada()
	{
		yield return new WaitForSeconds (2.0f);
		GameObject.FindGameObjectWithTag ("GameController").GetComponent<TurnedBase> ().enabled = true;
	}
		
	void ChecktoDestroy(int entrada)
	{
		for (int i = 0; i < _monster.Length; i++) {
			_monster[i].GetComponent<IdMonstro>().DestruiMonsters(entrada);
		}
	}
}
