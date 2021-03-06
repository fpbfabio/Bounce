﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Script to generate the floor periodically.
/// </summary>
public class SpawnFloor : MonoBehaviour {
    public GameObject prefab;
    public float x;
    public float y;
    public float z;

    private void GenerateFloor()
    {
        GameObject floor = GameObject.Instantiate(prefab);
        floor.transform.position = new Vector3(x, y, z);
        FloorMovement script = floor.GetComponent<FloorMovement>();
        script.enabled = false;
        Rigidbody rigidbody = floor.GetComponent<Rigidbody>();
        rigidbody.velocity = Vector3.back * 3;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            GameObject floor = other.gameObject;
            FloorMovement script = floor.GetComponent<FloorMovement>();
            script.enabled = true;
            GenerateFloor();
        }
    }
}
