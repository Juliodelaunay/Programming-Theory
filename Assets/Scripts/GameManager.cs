using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject explosion;
    
    private  int shield = 10;
    public static int Shield = 10;

    private int score=0;
    public static int Score=0;

    
    public static int level;
    
   

    public GameObject panelMenu;
    
   
     private void Awake()
    {
        if (instance == null)
        { instance = this; 
        DontDestroyOnLoad(gameObject);}
    }
    void Start()
    {
       
        level=1;
        shield=10;
        Shield=10;
        Score=0;
        score=0;
       
    }

    // Update is called once per frame
    void Update()
    {   // ABSTRACTION

        
        GetShield();
        ChangeLevel();
        GetScore();
        MainMenu();
    }

  

    private void GetShield()  // ENCAPSULATION
    {
        if (Shield != 0 && Shield > -10)
        {
            shield = Shield;
        }
    }

    private void ChangeLevel()
    {
        if ( score > 90)
        {
            level=2;
        }
    }

    private void GetScore()  // ENCAPSULATION
    {
        if (Score >= 0 )
        {
            score = Score;
        }
    }

    private void MainMenu()
    {
        if ( Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale=0;
            panelMenu.SetActive(true);
        }  
    }
       
    
    

}


