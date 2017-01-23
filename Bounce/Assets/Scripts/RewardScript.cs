using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Script to increment score when the player hits a capsule.
/// </summary>
public class RewardScript : MonoBehaviour {
    private Text score;
    public float timeScaleInc;

    // Use this for initialization
    void Start () {
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider col) {
		if (col.gameObject.CompareTag("Player"))
        {
            Time.timeScale += timeScaleInc;
            score.text = "" + (int.Parse(score.text) + 1);
            Destroy(this.gameObject);
        }
	}
}
