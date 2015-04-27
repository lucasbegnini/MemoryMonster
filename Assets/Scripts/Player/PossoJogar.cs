using UnityEngine;
using System.Collections;

public class PossoJogar : MonoBehaviour {

	private bool _PossoJogar;
	// Use this for initialization
	public void setPossoJogar (bool entrada) {
		_PossoJogar = entrada;
	}

	public bool getPossoJogar()
	{return _PossoJogar;	}
	// Update is called once per frame
	void Update () {
	
	}
}
