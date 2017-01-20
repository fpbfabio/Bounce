using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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
            PlayerPrefs.SetString("Score", score.text);
            SceneManager.LoadScene(2);
        }
    }
}
