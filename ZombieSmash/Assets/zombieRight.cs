﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieRight : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody> ().velocity = new Vector3(-1f, 0, -1f);
	}
	void OnCollisionEnter(Collision other){

		if (other.gameObject.tag == "zomb") 
			Destroy (other.gameObject);
	}
}
