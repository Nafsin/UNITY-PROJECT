using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour {
	public play movement;

	void OnCollisionEnter(Collision DetectCollision)
	{
		if (DetectCollision.collider.tag == "obstacles") 
		{
			Debug.Log ("Woops! The cube collided with something!!!!!");
			movement.enabled = false;
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
