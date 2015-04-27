using UnityEngine;
using System.Collections;

public class FimRodada : MonoBehaviour {

	void OnEnable()
	{
		StartCoroutine (Acabou ());

	}

	IEnumerator Acabou()
	{
		gameObject.GetComponent<NovaRodada> ().enabled = true;
		yield return new WaitForSeconds (1.0f);
		gameObject.GetComponent<FimRodada> ().enabled = false;
	}
}
