namespace VRTK{
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public class ButtonSpawner : VRTK_InteractableObject {

		public GameObject spawner;
		public GameObject mellon;

		public override void StartUsing(VRTK_InteractUse usingObject)
		{
			base.StartUsing(usingObject);
			Spawn();
		}

		void Start()
		{
			Time.fixedDeltaTime = 0.01f;
		}

		private void Spawn()
		{
			Debug.Log ("spawnaus");
			GameObject mellonClone = Instantiate(mellon, spawner.transform.position, gameObject.transform.rotation) as GameObject;
		}
	}
}