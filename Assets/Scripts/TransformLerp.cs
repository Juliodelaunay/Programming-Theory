using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformLerp : MonoBehaviour
{
    public GameObject objetivo;
    public bool seguirPosicion;
    public float acercamientoPosicion = 0.5f;
    public bool seguirRotacion;
    public float acercamientoRotacion = 0.5f;
      [SerializeField] private float cameraAxisX = -90f;
    [SerializeField] private float cameraAxisY = -360f;
    private new Transform camera;
    private Vector3 distancia;
    public GameObject referencia;
    
    void Start()
    {
        distancia=transform.position - objetivo.transform.position;
    }

    // Update is called once per frame
    void Update()
    
    { // RotatePlayer();
        if ( seguirPosicion)
        {
            transform.position = Vector3.Lerp(
                transform.position,objetivo.transform.position,acercamientoPosicion
            );
    
        }

        if (seguirRotacion)
        {
            transform.rotation = Quaternion.Lerp (
             transform.rotation,objetivo.transform.rotation,acercamientoRotacion   
            );
        }
       // transform.LookAt(objetivo.transform.position);
    }
      private void RotatePlayer()
    {   
        distancia=Quaternion.AngleAxis(Input.GetAxis ("Mouse X")* 2 ,Vector3.up) * distancia; 
        transform.position= objetivo.transform.position + distancia;
        transform.LookAt (objetivo.transform.position);
        Vector3 copiaRotacion = new Vector3(0,transform.eulerAngles.y,0);
        referencia.transform.eulerAngles=copiaRotacion;

        //cameraAxisX += Input.GetAxis("Mouse X");
      //  cameraAxisY -= Input.GetAxis("Mouse Y");
        //cameraAxisY = Mathf.Clamp(cameraAxisY, -60, 60);
        //Quaternion angulo = Quaternion.Euler(0, cameraAxisX, -5f);
       // transform.rotation = angulo;
        
       // camera.transform.localEulerAngles = new Vector3(cameraAxisY, -5, -5f);

    }
}
