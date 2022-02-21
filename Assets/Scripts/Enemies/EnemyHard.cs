using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHard : BaseEnemy // INHERITANCE

{   public float length = 35f;
    private float startPosition;
    private float counter;
    
    void Start()
    {   
        target = GameObject.Find("Player");
        startPosition=transform.position.x;
        InvokeRepeating ("ShotEnemy",1 , 4);
        soundManager = FindObjectOfType<SoundManager>();
    }

    // Update is called once per frame
    void Update()
    {   
        // ABSTRACTION
        
        MoveEnemy();
        DestroyEnemy();
        MoveEnemySide();    // POLYMORPHISM
    }
    
    private void MoveEnemySide()
    {   counter += Time.deltaTime * 10f;
        transform.position=new Vector3(Mathf.PingPong(counter,length) + startPosition,transform.position.y,transform.position.z);
    }
    public override void OnTriggerEnter(Collider other)  // POLYMORPHISM
    {
        if (other.gameObject.CompareTag("Laser"))
         {  soundManager.SeleccionAudio(1,1f);
          play = true;
              Destroy(gameObject);
         Instantiate(explosion,transform.position,transform.rotation);
         GameManager.Score +=20;
         }
        /* if(other.gameObject.CompareTag("Player"))
         {
             Destroy(gameObject);
             Destroy(target);
             Instantiate(explosion2,transform.position,transform.rotation);
         }*/
    }
}
