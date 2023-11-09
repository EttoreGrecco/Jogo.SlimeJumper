    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class PlayerController : MonoBehaviour
    {
        public Vector3 gravidade;
        public Vector3 jumpSpeed;
        Rigidbody rb;
        bool isGrounded = false;

        void Awake()
        {
        
            Physics.gravity = gravidade;

       
            rb = GetComponent<Rigidbody>();
        }

        void Update()
        {

        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && isGrounded)
        {
            rb.velocity = jumpSpeed;
            isGrounded = false;
        }
        }

        void OnCollisionEnter(Collision collision)
        {
            isGrounded = true;
        }
    }
