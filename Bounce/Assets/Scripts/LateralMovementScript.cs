using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LateralMovementScript : MonoBehaviour {
    public int speed;
    public Vector3 p1;
    public Vector3 p2;
    public Vector3 p3;
    private Rigidbody cameraRigidbody;
    private Vector3 p;
    private bool right;
    private bool left;
    private new Rigidbody rigidbody;
    private bool stopP1;
    private bool stopP2;
    private bool stopP3;

    // Use this for initialization
    void Start () {
        p = p2;
        cameraRigidbody = Camera.main.GetComponent<Camera>().GetComponent<Rigidbody>();
        rigidbody = GetComponent<Rigidbody>();
	}
	
    public void MoveLeft ()
    {
        if (p == p1)
        {
            return;
        }
        if (p == p2)
        {
            GoToP1();
        }
        else if (p == p3)
        {
            GoToP2();
        }
        rigidbody.velocity = new Vector3(-speed, rigidbody.velocity.y, rigidbody.velocity.z);
    }

    private void GoToP2()
    {
        p = p2;
        stopP1 = false;
        stopP2 = true;
        stopP3 = false;
    }

    private void GoToP1()
    {
        p = p1;
        stopP1 = true;
        stopP2 = false;
        stopP3 = false;
    }

    private void GoToP3()
    {
        p = p3;
        stopP1 = false;
        stopP2 = false;
        stopP3 = true;
    }

    public void MoveRight()
    {
        if (p == p3)
        {
            return;
        }
        if (p == p2)
        {
            GoToP3();
        }
        else if (p == p1)
        {
            GoToP2();
        }
        rigidbody.velocity = new Vector3(speed, rigidbody.velocity.y, rigidbody.velocity.z);
    }

    void FixedUpdate () {
        cameraRigidbody.gameObject.transform.position = new Vector3(transform.position.x, cameraRigidbody.gameObject.transform.position.y, cameraRigidbody.gameObject.transform.position.z);
        if (stopP1)
        {
            if (transform.position.x < p1.x)
            {
                Stop();
            }
        }
        else if (stopP2)
        {
            if (Mathf.Abs(transform.position.x - p2.x) < 0.2)
            {
                Stop();
            }
        }
        else if (stopP3)
        {
            if (transform.position.x > p3.x)
            {
                Stop();
            }
        }
	}

    private void Stop()
    {
        rigidbody.velocity = new Vector3(0, rigidbody.velocity.y, rigidbody.velocity.z);
        stopP1 = false;
        stopP2 = false;
        stopP3 = false;
    }

}
