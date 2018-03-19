using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour {

	//public GameObject player;
	public Animator ani;

	public SimpleMover move;


	// Use this for initialization
	void Start ()
	{
		ani = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space) && move.Crawling)
			{
				ani.Play("Jump");
			}
		if (Input.GetKeyDown(KeyCode.LeftShift) && move.Crawling)
			{
				ani.Play("StartPush");
			}
		if (Input.GetKey(KeyCode.W) && move.Crawling)
			{
				ani.Play("LoopWalk");
			}
		if (Input.GetKey(KeyCode.S) && move.Crawling)
			{
			ani.Play("LoopWalk");
			}
		if (Input.GetKeyDown(KeyCode.A) && move.Crawling)
			{
			ani.Play("LoopWalk");
			}
		if (Input.GetKeyDown(KeyCode.D) && move.Crawling)
			{
			ani.Play("LoopWalk");
			}
		if (Input.GetKey(KeyCode.W) && !move.Crawling)
		{
			ani.Play("Crawl");
		}
		if (Input.GetKey(KeyCode.S) && !move.Crawling)
		{
			ani.Play("Crawl");
		}
		if (Input.GetKeyDown(KeyCode.A) && !move.Crawling)
		{
			ani.Play("Crawl");
		}
		if (Input.GetKeyDown(KeyCode.D) && !move.Crawling)
		{
			ani.Play("Crawl");
		}
		if (Input.GetKeyDown(KeyCode.E) && move.Crawling)
			{
				ani.Play("Pushing");
			}
		if (Input.GetKeyDown(KeyCode.F) && move.Crawling)
		{
			ani.Play("PickUp");
		}
		if (Input.GetKeyDown(KeyCode.LeftControl)&& !move.Crawling)
		{
				ani.Play("GetDown");
		}
		if (Input.GetKeyDown(KeyCode.LeftControl)&& move.Crawling)
		{
			ani.Play("GetUp");
		}
	}
		
}
