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

   
    void Update()


    {  
        // ABSTRACTION

        MoveBullet();
        DestroyBullet();
    }
     

    private protected void DestroyBullet()
    {
        if (transform.position.z < -100f)
        {
            Destroy(gameObject);
        }
    }

    private protected void MoveBullet()
    {
         transform.Translate(Vector3.forward * Time.deltaTime * 30f);
    }

    public virtual void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.shield -=  1;
            Destroy(gameObject);
            Debug.Log(GameManager.shield);
        }
    }
}


