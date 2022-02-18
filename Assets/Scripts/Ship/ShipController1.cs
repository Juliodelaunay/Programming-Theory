using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController1 : MonoBehaviour
{
    
    [SerializeField] private float speed = 45f;
    private float lecturaHorizontal;
    public GameObject turbina1;
    public GameObject turbina2;
    [SerializeField] private float maxLeft=-25f;
    [SerializeField] private float maxRight=25f;
    public GameObject explosion;
    
   
   
    
     void Start()
    {
        turbina1.SetActive(true);
        turbina2.SetActive(true);
        

    }

    void Update()
    {   
       MoveShip();      //ASBTRACTION
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
        
            if (GameManager.gameOver==true)
            {   
                Instantiate(explosion,transform.position,transform.rotation);
                Destroy(gameObject);
            }
    } 
        
        

    
}
    
       

    
        

