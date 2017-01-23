using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script controls the floor movement, including its speed.
/// </summary>
public class FloorMovement : MonoBehaviour {
    private Rigidbody rigidbody;
    public int speed;

	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        rigidbody.velocity = speed * Vector3.back;
    }
}
