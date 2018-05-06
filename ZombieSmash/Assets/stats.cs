﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stats : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.name == "zombtxt") {
			GetComponent<TextMesh> ().text = "Zombies: " + GM.Instance.zombiesKilled;
		}
		if (gameObject.name == "timetxt") {
			GetComponent<TextMesh> ().text = "Time Elapsed: " + (int)GM.Instance.timeTotal + " seconds";
		}
		if (gameObject.name == "totalScore") {
			GetComponent<TextMesh> ().text = "Total Score: " + ((int)GM.Instance.timeTotal*10 + GM.Instance.zombiesKilled*100 - 10);
		}
		if (gameObject.name == "highScore") {
			GetComponent<TextMesh> ().text = "HighScores: " + PlayerPrefs.GetInt ("HighScore");
		}
	}
}
