using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Climb : MonoBehaviour
{
	public SimpleMover move;
	public GameObject player;

	public float distanceUp;
	public float distanceForward;

	private bool CanCurentlyClimb;

	//[SerializeField] public bool Crawling;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space) && CanCurentlyClimb)
		{
			Vector3 curPos = this.GetComponent<Rigidbody>().position;
			Vector3 newPos = new Vector3(0f, 0f + distanceUp, 0f+ distanceForward);
			Debug.Log(curPos+" "+newPos);
			this.GetComponent<Rigidbody>().transform.Translate(newPos);
			Debug.Log(this.GetComponent<Rigidbody>().position);
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag.Equals("Moveable") && move.Crawling)
		{
			Debug.Log("CanClimb");
			CanCurentlyClimb = true;
				
		}
	}

	private void OnCollisionExit()
	{
		CanCurentlyClimb = false;
	}
}
