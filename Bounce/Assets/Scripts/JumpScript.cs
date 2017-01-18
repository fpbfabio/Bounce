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
            Debug.Log("Jump");
        }
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButtonDown(0) && !jump)
        {
            StartJump();
        }
    }

    private void StartJump()
    {
        jump = true;
        Invoke("StopJump", 1);
    }

    private void StopJump()
    {
        jump = false;
    }
}
