using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speedPlayer;
    public GameObject bala;
    private float cooldown=0.5f;
     [SerializeField] private float cameraAxisX = -90f;
    [SerializeField] private float cameraAxisY = -360f;
    
     private new Transform camera;
     float turnSpeed=60f;
     Transform myT;
     
   
     

   
    
    // Start is called before the first frame update
    void Start()
    {
      Cursor.lockState = CursorLockMode.Locked;
      
     
     
            
    }

    // Update is called once per frame
    void Update()
    {  
        cooldown -= Time.deltaTime;
        shot();
       
       
        
        
        
        
    }
    private void Move()
    {
        /*if(Input.GetKey(KeyCode.D))
        {
            ship.transform.rotation=new Quaternion(0,0,0,-15);
        }
        /*if(Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * Time.deltaTime * speedPlayer;
        }
         if(Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * Time.deltaTime * speedPlayer;
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * Time.deltaTime * speedPlayer;
        }*/
       //  float ejeHorizontal = Input.GetAxis("Horizontal");
       // float ejeVertical = Input.GetAxis("Vertical");
        
       // transform.Translate(speedPlayer * Time.deltaTime * new Vector3(ejeHorizontal, 0, ejeVertical));
       //    if(Input.GetKeyDown(KeyCode.W))
        //{
          //  speedPlayer = 60;
           
        //}
         // if(Input.GetKeyDown (KeyCode.S))
        //{  
          //  speedPlayer = 20;
          // angleShip = Mathf.Max(ship.transform.Rotate,angleShip);
       // }
        /*if (Input.GetKey(KeyCode.D))
            {
           transform.Rotate(Vector3.back* 50f *Time.deltaTime);
              
            }*/
      

    
    } 
    
       
    /*private void RotatePlayer()
    {

        cameraAxisX += Input.GetAxis("Mouse X");
        cameraAxisY -= Input.GetAxis("Mouse Y");
        cameraAxisY = Mathf.Clamp(cameraAxisY, -60, 60);
        Quaternion angulo = Quaternion.Euler(0, cameraAxisX, -5f);
        transform.rotation = angulo;
        camera.transform.localEulerAngles = new Vector3(cameraAxisY, -5, -5f);

    }*/
    

    private void shot()
    {
        if(Input.GetButtonDown("Fire1") && (cooldown <= 0))
        {
            Instantiate (bala,transform.position,transform.rotation);
           
            cooldown=0.5f;
            
        }
        if(Input.GetButtonDown("Fire2") && (cooldown <= 0))
        {
            Instantiate (bala,transform.position,transform.rotation);
            cooldown=0.5f;
            
        }
    }

   

     private void Destroy()
    {   
        Destroy (gameObject,2f);
       

    }

    void turn()
    {
        float yaw=turnSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
        myT.Rotate(0,yaw,0);
    }
    
    /*private void OnTriggerEnter(Collider other)
    {
     
     if ( other.gameObject.CompareTag("Bullet"))
     {
         Destroy();
         
         
     }
    }*/
     
}
