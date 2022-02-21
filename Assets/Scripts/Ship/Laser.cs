using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{

     private float coolDown=2.5f;
     
     void Update()       // ABSTRACTION
    {
        MoveLLaser();
        DestroyLaser();
    }

    private void DestroyLaser()
    {
         coolDown -=   Time.deltaTime;
        if (coolDown <= 0f)
        {
            Destroy(gameObject);
        }
    }
   
    private void  OnTriggerEnter(Collider other)
    { if(other.gameObject.CompareTag("Enemy"))
        
    Destroy(gameObject);
    }
    
    private void MoveLLaser()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 40f);
    }
  
    
}
