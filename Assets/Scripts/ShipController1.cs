using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController1 : MonoBehaviour
{
    public GameObject cuerpoAvion;
    public float velocidad=20f;
    public float speed = 45f;
    public float lecturaHorizontal,lecturaVertical,lecturaLateral;
    public GameObject turbina1;
    public GameObject turbina2;
    AudioSource audioSource;
    protected bool play;
    private float maxLeft=-25f;
    private float maxRight=25f;
    
   
   
    
     void Start()
    {
        turbina1.SetActive(true);
        turbina2.SetActive(true);
        audioSource=GetComponent<AudioSource>();
//        audioSource.pitch=1f;;
    }

    // Update is called once per frame
    void Update()
    {   
       

        // AVANCE FIJO SIN LEER LOS EJES DEL TECLADO
       // transform.Translate ( Vector3.forward * velocidad * Time.deltaTime);

        // AQUI PONDREMOS LAS ROTACIONES EN LOS EJES X,Y,Z

        lecturaHorizontal=Input.GetAxis("Horizontal");
        transform.Translate (Vector3.right * lecturaHorizontal *speed *Time.deltaTime);
        if (transform.position.x > maxRight)
            {transform.position = new Vector3 (maxRight,transform.position.y,transform.position.z) ;}
        if (transform.position.x < maxLeft)
            {transform.position = new Vector3 (maxLeft,transform.position.y,transform.position.z) ;}    

       // lecturaVertical=Input.GetAxis("Vertical");
        //transform.Translate (Vector3.forward * lecturaVertical *speed * Time.deltaTime *2);

       /* lecturaLateral=Input.GetAxis("Lateral");
        cuerpoAvion.transform.Rotate(
            Vector3.forward * lecturaLateral * -giro * Time.deltaTime * 1f );

         ESTABILIZACION DE ALAS
        if (lecturaLateral == 0)
        {
            cuerpoAvion.transform.rotation = Quaternion.Slerp (cuerpoAvion.transform.rotation,transform.rotation,5f);
        }*/
           
           
          /* if(Input.GetKey(KeyCode.W))
                
        {    turbina1.SetActive(true);
             turbina2.SetActive(true);
           audioSource.pitch=2.5f;
           audioSource.volume=0.5f;
                
            velocidad  += 0.5f;
            if(velocidad>20f)
            {
                velocidad=20f;
            }
        }
          if(Input.GetKey(KeyCode.S))
        {    turbina1.SetActive(false);
            turbina2.SetActive(false);
            audioSource.pitch=1f;
            velocidad  -= 0.5f;
            if(velocidad<1f)
            {
                velocidad=1f;
            }
        if(velocidad<1.5f)
        
            engine1.SetActive(false);
            engine2.SetActive(false);
            audioSource.volume=0f;
            
        
        else 
        
            engine1.SetActive(true);
            engine2.SetActive(true);*/
    }        
        
        

    
}
    
       

    
        

