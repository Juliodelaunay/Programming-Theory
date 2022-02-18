using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject explosion;
    
    private  int shield = 10;
    public static int Shield = 10;

    public static float score;
    public static int level;
    
    private Transform ship;
    private GameObject player;

    public static bool gameOver=false;
   
     private void Awake()
    {
        if (instance == null)
        { instance = this; }
       DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        ship = GameObject.Find("T-Fighter").GetComponent<Transform>();
        player = GameObject.Find("Player").GetComponent<GameObject>();
        level=1;
    }

    // Update is called once per frame
    void Update()
    {   // ABSTRACTION

        GameOver();
        GetShield();
        
    }

    public void GameOver()
    {
        if ( shield < 0)
        {   
          gameOver=true;
          
        }
    }

    private void GetShield()  // ENCAPSULATION
    {
        if (Shield != 0 )
        {
            shield = Shield;
        }
    }
 

}


