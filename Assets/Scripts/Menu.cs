using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public static float speed = 1f;
    
    public void StartButton()
    {
        Score.CurrentScore = 0;
        SceneManager.LoadScene("Main");
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("Intro");
    }
    public void SetSpeed(float valMultiplier)
    {
        speed =  valMultiplier;
    }

    public void QuitButton()
    {
        Application.Quit();
    }
        
}
