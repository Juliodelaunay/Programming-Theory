using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
    private GameObject target;
    void Start()
    {
        target = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {   transform.Translate(Vector3.forward * Time.deltaTime * 30f);
        // Vector3 playerDirection = GetPlayerDirection();
         //MoveTowards(playerDirection);
    }
     private Vector3 GetPlayerDirection()
   {
        return target.transform.position - transform.position;
   }
    private void MoveTowards(Vector3 newDirection)
    {
        Vector3 direction   = (target.transform.position - transform.position).normalized;
        transform.position += 50f * newDirection.normalized * Time.deltaTime;
    }



}


