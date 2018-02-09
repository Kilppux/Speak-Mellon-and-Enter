using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MellonFire : MonoBehaviour {
    public Transform cannonTip;
    public GameObject mellon;
    
    
    public float speed;
    Vector3 randomDir;
    float timer = 1.0f;
	// Use this for initialization
	void Start () {
        
        
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer <=0)
        {
            float randomX = Random.Range(-1.4f, -0.6f);
            randomDir = new Vector3(randomX, 2, -1);
            Debug.Log(randomDir);

            GameObject mellonFab;
            mellonFab = Instantiate(mellon, cannonTip.position, transform.rotation);
            Rigidbody mellonRb = mellonFab.GetComponent<Rigidbody>();
            mellonRb.AddForce(randomDir * speed, ForceMode.Impulse);
            
            timer = 1.0f;

        }
         
        

    }
}
