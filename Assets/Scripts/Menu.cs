using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public static bool mute;
    public static float volume = 0.5f;
    
    public void Play()
    {
        SceneManager.LoadScene("Fish");
    }
}
