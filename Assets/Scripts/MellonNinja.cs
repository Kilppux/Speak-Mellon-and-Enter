namespace VRTK{
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MellonNinja : VRTK_InteractableObject {
    public GameObject score;
    //GameObject mellonscript;

	// Use this for initialization
	void Start () {
        //mellon = GameObject.Find("Mellon");
        //mellonscript = mellon.GetComponent<Squish>();
	}
	
	// Update is called once per frame

		private void OnCollisionEnter(Collision col) {
		if (col.gameObject.CompareTag ("mellon")) {
				col.gameObject.GetComponent<Squish> ().Squished();
				score.GetComponent<Basketball> ().score += 5;
        }
        
    }
}
}
