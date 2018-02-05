using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MellonSound : MonoBehaviour {

	public AudioClip hitSound;
	AudioSource audioSource;
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter()
	{
		Debug.Log ("aania");
		audioSource.PlayOneShot (hitSound);
	}
}
