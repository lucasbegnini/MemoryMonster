using UnityEngine;
using System.Collections;

public class EscolherCartas : MonoBehaviour {

	public int [] MonstrosEscolhidos;
	private int Qtde;
	void OnEnable()
	{
		Qtde = 0;
		if(Application.loadedLevelName.Equals("Online"))
		GameObject.FindGameObjectWithTag ("GameController").GetComponent<TurnBasedOnline> ().enabled = false;

		if(Application.loadedLevelName.Equals("Offline"))
		GameObject.FindGameObjectWithTag ("GameController").GetComponent<TurnedBase> ().enabled = false;

	}

	public void MonstroEscolhido(int IdMonstro)
	{
		MonstrosEscolhidos [Qtde] = IdMonstro;
//		Debug.Log (MonstrosEscolhidos [Qtde]);
		Qtde++;
		if (Qtde.Equals(MonstrosEscolhidos.Length))
		{
			if(Application.loadedLevelName.Equals("Offline"))
				gameObject.GetComponent<CheckEscolhas>().check(MonstrosEscolhidos[0],MonstrosEscolhidos[1]);

			if(Application.loadedLevelName.Equals("Online"))
				gameObject.GetComponent<CheckEscolhasOnline>().check(MonstrosEscolhidos[0],MonstrosEscolhidos[1]);
		}
	
	}
	

}
