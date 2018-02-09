using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eating : MonoBehaviour {

	public Transform target;
	//private float minDistance = 0.3f;
	//private float range;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//range = Vector3 (transform.position, target.position, minDistance);

		//if (range > minDistance) {
		//	Debug.Log (range);
		//	Destroy (target.gameObject);
		//}	
	}

	void OnCollisionEnter(Collision coll)
	{
		if (coll.gameObject.tag == "mellon") {
			Destroy (target.gameObject);
		}
	}
}
