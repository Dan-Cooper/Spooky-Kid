using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

	public Game game;

	private bool canPick;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (canPick && Input.GetKeyDown(KeyCode.F))
		{
			game.score++;
			Destroy(this.gameObject);
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		canPick = true;
	}

	private void OnCollisionExit(Collision other)
	{
		canPick = false;
	}
}
