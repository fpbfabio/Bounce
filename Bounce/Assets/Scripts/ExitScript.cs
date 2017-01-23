using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Script to exit game on back pressed.
/// </summary>
public class ExitScript : MonoBehaviour {

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }
}
