using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MellonNinja : MonoBehaviour {
    GameObject mellon;
    GameObject mellonscript;

	// Use this for initialization
	void Start () {
        mellon = GameObject.Find("mellon");
        mellonscript = mellon.GetComponent<Squish>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OntriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "mellon")
        {
            col.Squished();
        }
        
    }
}
