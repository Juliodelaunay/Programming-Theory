using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BulletController : MonoBehaviour
{
    public float speed=5f; 
    public GameObject explosion;
    private GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        target=GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    { //  Vector3 playerDirection = GetPlayerDirection();
      //  MoveTowards(playerDirection);

       
        
    }

private void Move()
{
    transform.position += Vector3.back * speed * Time.deltaTime;
}
  private void OnTriggerEnter(Collider other)
 {
      if ( other.gameObject.CompareTag("Shield"))
     {
         Destroy(gameObject);
         
         Instantiate(explosion,transform.position,transform.rotation);
     }
 }
 private void MoveTowards(Vector3 newDirection)
    {
        Vector3 direction   = (target.transform.position - transform.position).normalized;
        transform.position += speed * newDirection.normalized * Time.deltaTime;
    }

    private void LookAtPlayer(Vector3 newDirection)
    {
        Quaternion newRotation = Quaternion.LookRotation(newDirection);
        transform.rotation = newRotation;
    }
    

    /*public Vector3 GetPlayerDirection()
   {
        return target.transform.position - transform.position;
   }*/


     
 }





