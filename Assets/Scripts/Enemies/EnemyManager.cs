using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject[] spawners;
    public GameObject ball;
    public GameObject cube;
   
    private int nave = 2;

    
   

    void Start()
    {
        InvokeRepeating  ("SpawnEnemy",1f,2f);   
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    
    private void SpawnEnemy()
     {
      /* int i=Random.Range(0,spawners.Length);
        {
            Instantiate(ball,spawners[i].transform.position,spawners[i].transform.rotation);
        }*/

        switch (nave)
        {case 1:   Bola();
         break;
         case 2:   Cubo();
         break;
         
        }
     }
        private void Bola()
        {
            int i=Random.Range(0,spawners.Length);
        
            Instantiate(ball,spawners[i].transform.position,ball.transform.rotation);
        
        }

        private void Cubo()
        {
            int i=Random.Range(0,spawners.Length);
        
            Instantiate(cube,spawners[i].transform.position,cube.transform.rotation);
        
        }

      
        
     }




