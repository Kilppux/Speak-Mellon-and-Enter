namespace VRTK
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Magnet : VRTK_InteractableObject
    {

        public GameObject magneettiKarki;
        public GameObject mellon;
        public GameObject laser;
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
            laser.SetActive(true);
            if (Physics.Raycast(transform.position, transform.forward, out _hit, 100.0f))
            {
                Debug.Log("Magneettivoimaaaa");
                if (_hit.collider.gameObject.tag == "mellon")
                {
                    laser.SetActive(false);
                    Rigidbody rb = _hit.collider.gameObject.GetComponent<Rigidbody>();
                    _hit.collider.attachedRigidbody.useGravity = false;
                    rb.AddForce((magneettiKarki.transform.position - _hit.collider.gameObject.transform.position).normalized * 300);
                    //_hit.collider.gameObject.transform.position = magneettiKarki.transform.position;
                    Debug.Log("Meloniiiii tuleeeee");
                }
            }
        }

        void OnTriggerEnter(Collider col)
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
}