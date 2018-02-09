using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagneettiStopper : MonoBehaviour {

    public GameObject magneettieste;
    public GameObject mellon;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter (Collider col)
    {
        if (col.gameObject.tag == "mellon")
        {
            Debug.Log("Osuttiiiin");
            Rigidbody rb = col.gameObject.GetComponent<Rigidbody>();
            rb.velocity = Vector3.zero;
            col.attachedRigidbody.useGravity = true;
        }
    }
}
