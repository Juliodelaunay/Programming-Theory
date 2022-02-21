using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ShipController1 : MonoBehaviour
{
    
    [SerializeField] private float speed = 45f;
    private float lecturaHorizontal;
    public GameObject turbina1;
    public GameObject turbina2;
    [SerializeField] private float maxLeft=-25f;
    [SerializeField] private float maxRight=25f;
    public GameObject explosion;
    public GameObject panelOver;
    private bool gameOver;
    public GameObject shieldS;
    public float shieldShip=10;

    
   
   
    
     void Start()
    {
        turbina1.SetActive(true);
        turbina2.SetActive(true);
        

    }

    void Update()
    {   
       MoveShip();      //ASBTRACTION
       GameOverr();
       GameOver();
      

    }    

    private void   MoveShip()
    {
         lecturaHorizontal=Input.GetAxis("Horizontal");
        transform.Translate (Vector3.right * lecturaHorizontal *speed *Time.deltaTime);
        if (transform.position.x > maxRight)
            {transform.position = new Vector3 (maxRight,transform.position.y,transform.position.z) ;}
        if (transform.position.x < maxLeft)
            {transform.position = new Vector3 (maxLeft,transform.position.y,transform.position.z) ;}   
    }
    
    private void GameOver()
    {
        
            if (gameOver==true)
            {   GameManager.Shield=10;
                GameManager.Score=0;
                Instantiate(explosion,transform.position,transform.rotation);
                Destroy(gameObject);
                panelOver.SetActive(true);
                shieldS.SetActive(false);



            }
    } 
     public void GameOverr()
    {
        if ( GameManager.Shield < 0)
        {   
           gameOver=true;
          
       }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            gameOver=true;
        }
    }
        

    
}
    
       

    
        

