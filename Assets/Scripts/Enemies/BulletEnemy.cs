using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
    private GameObject target;
    public GameObject impact;
    protected SoundManager soundManager;
    protected bool play;
    
    void Start()
    {
        target = GameObject.Find("Player");
         soundManager = FindObjectOfType<SoundManager>();
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
            Instantiate (impact,transform.position,transform.rotation);
            GameManager.Shield -= 1;
            soundManager.SeleccionAudio(1,1f);
            play = true;
            Destroy(gameObject);
            Debug.Log(GameManager.Shield);
         }
    }
}


