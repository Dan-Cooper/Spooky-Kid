using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{

	public Interact inter;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.F) && inter.CanPres)
		{
			GetComponent<Collider>().isTrigger = true;

		}
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag.Equals("Player"))
		{
			inter.CanPres = true;
		}
	}

	private void OnCollisionExit(Collision other)
	{
		if (other.gameObject.tag.Equals("Player"))
		{
			inter.CanPres = false;
		}
	}
}
