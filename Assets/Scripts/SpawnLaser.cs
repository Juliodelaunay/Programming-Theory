using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLaser : MonoBehaviour
{
    public GameObject laser;
    private bool canShot = false;
      public float cancold = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShotLaser();
    }

     private void ShotLaser()
        {    
           
             cancold -= Time.deltaTime;
            if (cancold <= 0) { canShot=true;}

            if(Input.GetKeyDown(KeyCode.Space) && canShot)
            {
                Instantiate (laser,transform.position,transform.rotation);
                cancold = 0.3f;
                canShot = false;
            }
        }
}
