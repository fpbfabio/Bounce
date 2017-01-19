using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour {
    private Rigidbody rigidbody;
    private bool jump;
    public int jumpForce;

    // Use this for initialization
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (jump)
        {
            rigidbody.AddForce(Vector3.up * jumpForce);
        }
    }
    
    public void StartJump()
    {
        jump = true;
        Invoke("StopJump", 1);
    }

    private void StopJump()
    {
        jump = false;
    }
}
