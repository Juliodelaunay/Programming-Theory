using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuResume : MonoBehaviour
{
    public GameObject panel;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
