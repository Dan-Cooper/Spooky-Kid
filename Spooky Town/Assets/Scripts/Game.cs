using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{

	public int score;

	public int maxScore;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (score >= maxScore)
		{
			//end game
			Application.Quit ();
		}
	}
}
