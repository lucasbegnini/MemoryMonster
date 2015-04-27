using UnityEngine;
using System.Collections;

public class CleanPosicoesUsadas : MonoBehaviour {

	private bool [] _posicaoUsadas;

	// Use this for initialization
	void Start () {

		_posicaoUsadas = GameObject.FindGameObjectWithTag ("Controller").GetComponent<InstanciarMonstro> ().getSizePosicao ();
		//Limpa as posicoes usadas
		cleanPosicaoUsada ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void cleanPosicaoUsada()
	{
		for(int i = 0; i < _posicaoUsadas.Length; i++)
		{
			_posicaoUsadas[i] = false;
		}
	}
}
