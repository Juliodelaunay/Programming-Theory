using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject[] spawners;
    public GameObject enemy;
    public GameObject enemyHard;
    

    
   

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
        switch (GameManager.level)
        {case 1:   SpawnEnemyBase();
         break;
         case 2:   SpawnEnemyHard();
         break;
         
        }
     }
        private void SpawnEnemyBase()
        {
            int i=Random.Range(0,spawners.Length);
        
            Instantiate(enemy,spawners[i].transform.position,enemy.transform.rotation);
        
        }

        private void SpawnEnemyHard()
        {
            int i=Random.Range(0,spawners.Length);
        
            Instantiate(enemyHard,spawners[i].transform.position,enemyHard.transform.rotation);
        
        }

      
        
     }




