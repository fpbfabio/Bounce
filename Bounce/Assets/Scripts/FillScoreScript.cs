using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Script to fill score in game over scene.
/// </summary>
public class FillScoreScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Text text = GetComponent<Text>();
        text.text = text.text + PlayerPrefs.GetString("Score");
    }
}
