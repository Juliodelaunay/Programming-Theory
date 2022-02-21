using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

    


public class MenuResume : MonoBehaviour
{
    public GameObject panel;
    public Image shieldBar;
  

    
    public void Resume()
    {
        panel.SetActive(false);
        Time.timeScale=1;
    }
    public void Restart()

    {   Time.timeScale=1;
        panel.SetActive(false);
        SceneManager.LoadScene("Main");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
