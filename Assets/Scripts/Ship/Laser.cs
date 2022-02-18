using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{

     private float coolDown=2.5f;
     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        transform.Translate(Vector3.forward * Time.deltaTime * 40f);
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
    { if(other.gameObject.CompareTag("Eye"))
        
    Destroy(gameObject);
     }
    
  
    
}
