﻿namespace VRTK
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Magnet : VRTK_InteractableObject
    {

        public GameObject magneettiKarki;
        public GameObject mellon;
        private float force;

        public override void StartUsing(VRTK_InteractUse usingObject)
        {
            base.StartUsing(usingObject);
            Magneetti();
        }

        // Use this for initialization
        void Start()
        {
            Time.fixedDeltaTime = 0.01f;
        }

        private void Magneetti()
        {
            Debug.Log("Magneettia kaytetaan");
            RaycastHit _hit;
            Debug.DrawRay(transform.position, transform.forward, Color.red);
            if (Physics.Raycast(transform.position, Vector3.forward, out _hit, 100.0f))
            {
                Debug.Log("Magneettivoimaaaa");
                if (_hit.collider.gameObject.tag == "mellon")
                {
                    _hit.collider.gameObject.transform.position = magneettiKarki.transform.position;
                    Debug.Log("Meloniiiii");
                }
            }
        }
    }
}