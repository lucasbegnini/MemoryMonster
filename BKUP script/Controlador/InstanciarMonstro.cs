using UnityEngine;
using System.Collections;

public class InstanciarMonstro : MonoBehaviour {
	public Vector3 [] posicao;
	private bool [] posicaoUsada;
	public GameObject [] monsters;
	private GameObject[] _monsters;
	private int idPosicao;
	bool achou;

	// Use this for initialization
	void Start () {	
		//Instancia os monstros
		instanciarMonstros ();
		//Limpa as posicoes usadas
		posicaoUsada = new bool[12];
		Debug.Log (posicaoUsada.Length);
		cleanPosicaoUsada ();
	}
	
	void instanciarMonstros()
	{
		for(int i = 0; i < monsters.Length ; i++)
		{
		 //   RandomNumber();
			//_monsters[i] = GameObject.Instantiate(monsters[i],monsters[i].transform.position, monsters[i].transform.rotation) as GameObject;
			_monsters[i] = GameObject.Instantiate(monsters[i]);
		}
	}
	
	
//	void RandomNumber()
//	{
//
//		achou = false;
//		while(!achou){
//			int ran = Random.Range (0, 11);
//			if(!posicaoUsada[ran])
//			{
//				posicaoUsada[ran] = true;
//				idPosicao = ran;
//				achou = true;
//			}
//		}
//
//	}

	void cleanPosicaoUsada()
	{

		for(int i = 0; i < posicao.Length; i++)
		{
			posicaoUsada[i] = false;
		}
	}

	public bool [] getSizePosicao()
	{return posicaoUsada;}

}
