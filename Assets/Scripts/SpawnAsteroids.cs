using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAsteroids : MonoBehaviour
{
    public GameObject [] spawnPoints;
    public GameObject [] asteroids;
    void Start()
    {
        InvokeRepeating ("SpawnRocks",0,8f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnRocks()
    {
        for (int x = 0 ; x < asteroids.Length ; x ++)
       
        
        for(int i = 0; i < spawnPoints.Length ; i ++)
        
          {  Instantiate(asteroids[x],spawnPoints[i].transform.position,spawnPoints[i].transform.rotation);
        }
    }

    
}
