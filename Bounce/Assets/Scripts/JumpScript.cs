using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Script to control the jump of the ball.
/// </summary>
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
        if (transform.position.y > 0.3f)
            return;
        jump = true;
        Invoke("StopJump", 1);
    }

    private void StopJump()
    {
        jump = false;
    }
}
