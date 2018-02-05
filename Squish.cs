namespace VRTK{
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public class Squish : VRTK_InteractableObject {

		public GameObject particles;

		public override void StartUsing(VRTK_InteractUse usingObject){
			base.StartUsing(usingObject);
			Spawn();
		}

		void Start(){
			
		}

		private void Spawn(){
			Debug.Log ("Squish");
			GameObject clone = Instantiate(particles, gameObject.transform.position, gameObject.transform.rotation) as GameObject;
			clone.transform.localScale = gameObject.transform.localScale * 2;
			Destroy (clone, 2f);
			Destroy (gameObject,0.1f);
		}
	}
}