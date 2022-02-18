using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotLaser : MonoBehaviour
{
    public GameObject laser;
    private bool canShot = false;
      public float cancold = 0.3f;
  
  
    void Update()       
    {
        Laser();        // ABSTRACTION
    }

     private void Laser()
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
