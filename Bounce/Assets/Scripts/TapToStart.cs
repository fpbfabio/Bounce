using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TapToStart : MonoBehaviour {
    public int nextSceneIndex = 1;
	
	void Update ()
    {
		if (Input.GetMouseButtonUp(0))
        {
            LoadGame();
        }
	}

    private void LoadGame()
    {
        SceneManager.LoadScene(nextSceneIndex);
    }
}
