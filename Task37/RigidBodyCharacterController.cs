
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Task37
{
    public class RigidbodyController1 : MonoBehaviour
    {
        Rigidbody rigidbody;
        Vector3 input;
        bool jump = false;

        float battahSpeed = 4f;
        public float R = 0f;

        void Start()
        {
            rigidbody = GetComponent<Rigidbody>();
            rigidbody.freezeRotation = true;
            rigidbody.mass = 1;
        }

        void Update() 
        {
            input = new Vector3(-Input.GetAxisRaw("Horizontal"),
                                0,
                                -Input.GetAxisRaw("Vertical"));
            input = input.normalized * battahSpeed;

            input.y = rigidbody.velocity.y;

            if (Input.GetKeyUp(KeyCode.Space))
            {
                jump = true;
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                R = 90;
            }
            else if(Input.GetKey(KeyCode.RightArrow))
            {
                R = -90;
            }
            else if(Input.GetKey(KeyCode.UpArrow))
            {
                R = -180;
            }
            else if(Input.GetKey(KeyCode.DownArrow))
            {
                R = 0;
                
            }
            transform.rotation = Quaternion.Euler(new Vector3(0,R, 0));
        }

        void FixedUpdate()
        {
            if (jump)
            {
                rigidbody.drag = 0.5f;
                rigidbody.AddForce(Vector3.up *10, ForceMode.Impulse);
                jump = false;
            }
            else
            {
                rigidbody.drag = 0;
                rigidbody.velocity = input;
            }
        }
    }
}
