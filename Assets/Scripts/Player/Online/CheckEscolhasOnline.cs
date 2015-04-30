using UnityEngine;
using System.Collections;

public class CheckEscolhasOnline : MonoBehaviour {
	private GameObject [] _monster;
	private PhotonView myPhotonView;
	void Start () {

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
		myPhotonView = gameObject.GetComponent<PhotonView>();
		
		this.myPhotonView.RPC ("FimdaRodada", PhotonTargets.All);
	}


	[RPC]
	void FimdaRodada()
	{
		gameObject.GetComponent<EscolherCartas> ().enabled = false;
		gameObject.GetComponent<PossoJogarOnline> ().setOFF();
		StartCoroutine (AtivarFimRodada ());
	}
	
	IEnumerator AtivarFimRodada()
	{
		yield return new WaitForSeconds (2.0f);
		GameObject.FindGameObjectWithTag ("GameController").GetComponent<TurnBasedOnline> ().enabled = true;
	}
	
	void ChecktoDestroy(int entrada)
	{
		_monster = GameObject.FindGameObjectsWithTag ("Monsters");
		for (int i = 0; i < _monster.Length; i++) {
			_monster[i].GetComponent<IdMonstroOnline>().DestruiMonsters(entrada);
		}
	}
}
