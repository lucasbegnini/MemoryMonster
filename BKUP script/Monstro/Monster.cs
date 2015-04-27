using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour {

	private int Id;

	void OnMouseDown()
	{
		if(GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().PossoJogar())
		{
			GameObject.FindGameObjectWithTag ("Player").GetComponent<Player> ().setCartaEscolhida (Id);
	}


	}
	public int getId()
	{return Id;}
}
