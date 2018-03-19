using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour {

	
	public SimpleMover move;

	public bool CanMove;
	public bool CanPres;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void Action(GameObject Door)
	{
		
	}

	private void OnCollisionStay(Collision other)
	{
		if (Input.GetKey(KeyCode.E) && CanMove && other.gameObject.tag.Equals("Moveable"))
		{
			other.gameObject.GetComponent<Rigidbody>().isKinematic = false;

		}
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag.Equals("Moveable"))
		{
			CanMove = true;
		}

	}

	private void OnCollisionExit(Collision other)
	{
		if (other.gameObject.tag.Equals("Moveable"))
		{
			CanMove = false;
			other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
			Debug.Log("left");
		}

	}
}
