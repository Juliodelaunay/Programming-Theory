using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemyHard : BulletEnemy  // INHERITANCE
{
  
    

    void Start()
    {
       soundManager = FindObjectOfType<SoundManager>();
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
            Instantiate (impact,transform.position,transform.rotation);
            GameManager.Shield -=  3;
            soundManager.SeleccionAudio(1,1f);
            play = true;
            Destroy(gameObject);
            
        }
    }

}
