﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RewardScript : MonoBehaviour {
    private Text score;

	// Use this for initialization
	void Start () {
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void OnCollisionEnter (Collision col) {
		if (col.gameObject.CompareTag("Player"))
        {
            score.text = "" + (int.Parse(score.text) + 1);
            Destroy(this.gameObject);
        }
	}
}