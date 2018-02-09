using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetButt : MonoBehaviour {

	public Text scoreText;
	private int score = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "Score : " + score;
	}

	private void OnTriggerEnter(Collider other) {
		if (other.tag == "targetbutt") {
			Debug.Log ("Osuit maalitauluun.");
			score += 5;
		}
	}
}
