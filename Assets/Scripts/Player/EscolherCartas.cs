using UnityEngine;
using System.Collections;

public class EscolherCartas : MonoBehaviour {

	public int [] MonstrosEscolhidos;
	private int Qtde;
	void OnEnable()
	{
		Qtde = 0;
		GameObject.FindGameObjectWithTag ("GameController").GetComponent<TurnedBase> ().enabled = false;


	}

	public void MonstroEscolhido(int IdMonstro)
	{
		MonstrosEscolhidos [Qtde] = IdMonstro;
//		Debug.Log (MonstrosEscolhidos [Qtde]);
		Qtde++;
		if (Qtde.Equals(MonstrosEscolhidos.Length))
		{
			gameObject.GetComponent<CheckEscolhas>().check(MonstrosEscolhidos[0],MonstrosEscolhidos[1]);
		}
	
	}
	

}
