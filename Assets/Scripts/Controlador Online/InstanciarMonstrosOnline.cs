using UnityEngine;
using System.Collections;

public class InstanciarMonstrosOnline : MonoBehaviour {

	public Vector3 [] posicoes;
	public bool [] posicoesUsadas;
	private int posicaoEscolhida;


	void OnJoinedRoom()
	{
		instanciarMonstros ();
	}

	void instanciarMonstros()
	{
		for (int i = 0; i < posicoes.Length; i++) {
			SelectPosicao();
		//	GameObject.Instantiate(monsters[i],posicoes[posicaoEscolhida],monsters[i].transform.rotation);
		
		}
	}

	void SelectPosicao()
	{
		int rand = Random.Range (0, 12);
		if (posicoesUsadas [rand] == false) {
			posicaoEscolhida = rand;
			posicoesUsadas[rand] = true;
		} else {
			SelectPosicao();
		}
	}
}
