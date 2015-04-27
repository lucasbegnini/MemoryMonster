using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	private int _score;
	// Use this for initialization
	void Start () {
		_score = 0;
	
	}
	
	public void setScore()
	{
		_score++;
	}

	public int getScore()
	{ return _score; }
}
