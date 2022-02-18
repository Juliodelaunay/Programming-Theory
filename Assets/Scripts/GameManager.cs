using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject explosion;
    public static int shield = 10;
    public static float score;
    private Transform ship;
    private GameObject player;
    public static int level;


    private void Awake()
    {
        if (instance == null)
        { instance = this; }
       DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        ship = GameObject.Find("Player").GetComponent<Transform>();
        player = GameObject.Find("Player").GetComponent<GameObject>();
        level=2;
    }

    // Update is called once per frame
    void Update()
    {   // ABSTRACTION

        GameOver();
    }

    private void GameOver()
    {
        if ( shield <= 0)
        {
           // Time.timeScale=0;
            Instantiate(explosion,ship);
            Destroy(player);
        }
    }

}


