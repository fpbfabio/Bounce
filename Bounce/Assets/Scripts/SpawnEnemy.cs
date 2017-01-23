using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour {
    public int startTime;
    public int interval;
    public GameObject prefab;

    private void Generate()
    {
        GameObject enemy = GameObject.Instantiate(prefab);
        int randomChild = (int) Mathf.Floor(Random.Range(0, transform.childCount - 0.000001f));
        enemy.transform.position = transform.GetChild(randomChild).position;
    }

    // Update is called once per frame
    void Start ()
    {
        InvokeRepeating("Generate", startTime, interval);
    }
}
