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


    void Start()
    {
        target = GameObject.Find("Player");
        InvokeRepeating ("ShotEnemy",1 , 2);
        Sshield=GameObject.Find("Shield");
        //Sshield.SetActive(false);
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
         {   Destroy(gameObject);
         Instantiate(explosion,transform.position,transform.rotation);
         GameManager.Score +=10;
         }
         /*if(other.gameObject.CompareTag("Player"))
         {
             Destroy(gameObject);
             Destroy(target);
             Destroy(Sshield);
             Instantiate(explosion2,transform.position,transform.rotation);
             Sshield.SetActive(false);
         }*/
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
