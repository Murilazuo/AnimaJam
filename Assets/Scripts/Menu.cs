using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public static float volume = 0.5f;
    
    public void Play()
    {
        SceneManager.LoadScene("Fish");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ChangerVolume(Slider slider)
    {
        volume = slider.value;
    }
}
