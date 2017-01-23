using UnityEngine;

/// <summary>
/// Script to prevent game object from being destroyed on scene change
/// </summary>
public class DontDestroy : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
