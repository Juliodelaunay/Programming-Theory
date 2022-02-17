using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : MonoBehaviour
{
    public GameObject explosion;
    public GameObject explosion2;
   private GameObject target;
   public GameObject bullet;


    void Start()
    {
        target = GameObject.Find("Player");
        InvokeRepeating ("ShotEnemy",1 , 4);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 20f);
        //Vector3 playerDirection = GetPlayerDirection();
        //MoveTowards(playerDirection + Vector3.forward);

        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Laser"))
         {   Destroy(gameObject);
         Instantiate(explosion,transform.position,transform.rotation);
         }
         if(other.gameObject.CompareTag("Player"))
         {
             Destroy(gameObject);
             Destroy(target);
             Instantiate(explosion2,transform.position,transform.rotation);
         }
    }
    
     private Vector3 GetPlayerDirection()
   {
        return target.transform.position - transform.position;
   }
    private void MoveTowards(Vector3 newDirection)
    {
        Vector3 direction   = (target.transform.position - transform.position).normalized;
        transform.position += 15f * newDirection.normalized * Time.deltaTime;
    }

    private void ShotEnemy()
    {
        Instantiate(bullet,transform.position,transform.rotation);
    }
}
