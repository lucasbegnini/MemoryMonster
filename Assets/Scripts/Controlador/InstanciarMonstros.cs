using UnityEngine;
using System.Collections;

public class InstanciarMonstros : MonoBehaviour {

	public GameObject[] monsters;
	public Vector3 [] posicoes;
	public bool [] posicoesUsadas;
	private int posicaoEscolhida;
	// Use this for initialization
	void Start () {
		instanciar ();
	}

	void instanciar()
	{
		for (int i = 0; i < monsters.Length; i++) {
			SelectPosicao();
			GameObject.Instantiate(monsters[i],posicoes[posicaoEscolhida],monsters[i].transform.rotation);
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
