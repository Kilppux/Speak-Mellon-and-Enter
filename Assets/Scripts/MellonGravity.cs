using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MellonGravity : MonoBehaviour {

    public GameObject mellon;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision col)
    {
        GetComponent<Collider>().attachedRigidbody.useGravity = true;
    }
}
