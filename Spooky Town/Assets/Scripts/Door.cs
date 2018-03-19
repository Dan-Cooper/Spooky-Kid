using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
	public GameObject[] Buttons;


	public GameObject D;

	public bool andGate = true; //Only aplies if there are 2 or more buttons.
	public bool orGate; //Only aplies if there are 2 or more buttons.
	
	
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.F))
		{
			if (andGate)
			{
				if (ButtonAnd()) Destroy(D);
			}
			if (orGate)
			{
				if (ButtonOr()) Destroy(D);
			}
		}
	}

	private bool ButtonAnd()
	{
		int i = 0;
		foreach (GameObject button in Buttons)
		{
			if (button.GetComponent<Collider>().isTrigger)
			{
				i++;
				Debug.Log("1+" + i + "size" + Buttons.Length);
			}
		}
		if (i >= Buttons.Length)
		{
			
			return true;
		}
		Debug.Log("Value" + i +"Lenght"+ Buttons.Length);
		return false;
	}
	
	private bool ButtonOr()
	{
		int i = 0;
		foreach (GameObject button in Buttons)
		{
			if (!button.GetComponent<Collider>().isTrigger)
			{
				i++;
			}
		}
		if(i== Buttons.Length) return true;

		return false;
	}
}
