using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private bool possojogar;
	private int[] cartasEscolhidas;
	private int idPosicaoCarta;
	private int score;
	// Use this for initialization
	void Start () {
		possojogar = false;
		//Inicializa as cartas escolhidas por ele - Nenhuma - e limita o numero de cartas - 2
		cartasEscolhidas = new int[1];
		cleanEscolhidas ();
		score = 0;
	}
	public bool PossoJogar()
	{return possojogar;}

	public void setPossoJogar(bool entrada)
	{ possojogar = entrada;}

	public void cleanEscolhidas()
	{cartasEscolhidas [0] = cartasEscolhidas [1] = idPosicaoCarta = 0;}

	public void setCartaEscolhida(int entrada)
	{
		cartasEscolhidas [idPosicaoCarta] = entrada;
		idPosicaoCarta++;
		if (idPosicaoCarta > 1)
						checkRight (); 
	}

	void checkRight()
	{
		possojogar = false;
		if (cartasEscolhidas [0] == cartasEscolhidas [1]) {
			GameObject.FindGameObjectWithTag ("Controlador").GetComponent<Controlador> ().PlayerAcertou (cartasEscolhidas[0]);
		}else{
			GameObject.FindGameObjectWithTag ("Controlador").GetComponent<Controlador> ().PlayerErrou ();
		}
	}

	public void pontuar()
	{score++;}
}
