using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : MonoBehaviour
{
    public GameObject explosion;
    public GameObject explosion2;
    public GameObject target;
    public GameObject bullet;
    public GameObject Sshield;
    public GameObject Menu;
     protected SoundManager soundManager;
    protected bool play;


    void Start()
    {
        target = GameObject.Find("Player");
        InvokeRepeating ("ShotEnemy",1 , 2);
        Sshield=GameObject.Find("Shield");
        soundManager = FindObjectOfType<SoundManager>();
        
    }

    // Update is called once per frame
    void Update()
    {   
        // ABSTRACTION

        MoveEnemy();
        
        DestroyEnemy();
        
    }

    public virtual void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Laser"))
         {
          soundManager.SeleccionAudio(1,1f);
          play = true;
          Destroy(gameObject);
          Instantiate(explosion,transform.position,transform.rotation);
          GameManager.Score +=10;
         }
         
    }
    
    

    private void ShotEnemy()
    {
        Instantiate(bullet,transform.position,transform.rotation);
    }
    protected void DestroyEnemy()
    {
        if ( transform.position.z < -45f)
        {
            Destroy (gameObject);
        }
    }
    protected virtual void MoveEnemy()
        {
            transform.Translate(Vector3.forward * Time.deltaTime * 20f);
        }
    
    
}
