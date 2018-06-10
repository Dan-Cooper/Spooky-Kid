using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{

	public int score;

	public int maxScore = 7;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (score >= maxScore)
		{
			//end game
			SceneManager.LoadScene(0);
			//Application.Quit ();
		}
	}
}
