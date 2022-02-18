using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemyHard : BulletEnemy  // INHERITANCE
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   //  ABSTRACTION

        MoveBullet();
        DestroyBullet();
    }

    public override void OnTriggerEnter(Collider other)   //  POLYMORPHISM
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.shield -=  3;
            Destroy(gameObject);
            Debug.Log(GameManager.shield);
        }
    }

}
