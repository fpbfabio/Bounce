using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>
/// Script to save score and load game over scene.
/// </summary>
public class EndGameScript : MonoBehaviour {
    private Text score;

    // Use this for initialization
    void Start()
    {
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Enemy"))
        {
            Time.timeScale = 1;
            PlayerPrefs.SetString("Score", score.text);
            SceneManager.LoadScene(2);
        }
    }
}
