using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Destroy everything that collides with this game object.
/// </summary>
public class KillScript : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        GameObject.Destroy(other.gameObject);
    }
}
