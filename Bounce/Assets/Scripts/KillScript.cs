using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillScript : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        GameObject.Destroy(other.gameObject);
    }
}
