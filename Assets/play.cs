﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play : MonoBehaviour {
	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb.useGravity = true;
		//rb.AddForce(200,300,0);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("w"))
			{
			rb.AddForce(0, 0, 20);
	}
		if(Input.GetKey("s"))
		{
			rb.AddForce(0, 0, -20);

		}if(Input.GetKey("a"))
		{
			rb.AddForce(-20, 0, 0);

		}if(Input.GetKey("d"))
		{
			rb.AddForce(20, 0, 0);
		}
}
}