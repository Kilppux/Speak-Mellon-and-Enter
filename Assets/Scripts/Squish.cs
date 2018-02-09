namespace VRTK{
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public class Squish : VRTK_InteractableObject {

		public GameObject particles;

		public override void StartUsing(VRTK_InteractUse usingObject){
			base.StartUsing(usingObject);
			Squished();
		}

		void Start(){
			
		}

		public void Squished(){
			//Debug.Log ("Squish");
			GameObject clone = Instantiate(particles, gameObject.transform.position, gameObject.transform.rotation) as GameObject;
			clone.transform.localScale = gameObject.transform.localScale * 1.8f;
			Destroy (clone, 2f);
			Destroy (gameObject);
		}


	/*void OnCollisionEnter(Collision col) {
		if (col.gameObject.CompareTag ("miekka")) {
				Destroy (gameObject);
		}
		}*/
	}
}