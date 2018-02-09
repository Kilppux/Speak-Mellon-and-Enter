namespace VRTK{
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public class MellonFireActivate : VRTK_InteractableObject 
	{

		public GameObject Cannon;
		public AudioClip spawnSound;
		AudioSource audioSource;

		public override void StartUsing(VRTK_InteractUse usingObject)
		{
			base.StartUsing(usingObject);
			MellonFireActivointi();
		}

		void Start()
		{
			audioSource = GetComponent<AudioSource> ();
		}

		private void MellonFireActivointi()
		{
			Cannon.SetActive (true);
			//Debug.Log ("spawnaus");
			//audioSource.PlayOneShot (spawnSound);
		}

	}
}