using UnityEngine;
using System.Collections;

public class InstanciarMonstrosOnline : MonoBehaviour {

	public GameObject[] monsters;
	public Vector3 [] posicoes;
	public bool [] posicoesUsadas;
	private int posicaoEscolhida;


	void OnJoinedRoom()
	{
		if (PhotonNetwork.playerList.Length == 1) {
			instanciarMonstros ();
		}
	}

	void instanciarMonstros()
	{
		for (int i = 0; i < posicoes.Length; i++) {
			SelectPosicao();
			GameObject monster = PhotonNetwork.Instantiate(monsters[i].name,posicoes[posicaoEscolhida],monsters[i].transform.rotation,0);
			VirarCartaOnline _viracarta = monster.GetComponent<VirarCartaOnline>();
			_viracarta.enabled = true;
			IdMonstroOnline _idMonstro = monster.GetComponent<IdMonstroOnline>();
			_idMonstro.enabled = true;
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

	void Start()
	{

	}
}
