using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotLaser : MonoBehaviour
{
    public GameObject laser;
    private bool canShot = false;
    public float cancold = 0.3f;
    protected SoundManager soundManager;
    protected bool play;
  
    void Start()
    {
         soundManager = FindObjectOfType<SoundManager>();
    }
    void Update()       
    {
        Laser();        // ABSTRACTION
    }

     private void Laser()
        {    
            cancold -= Time.deltaTime;
            if (cancold <= 0) { canShot=true;}

            if(Input.GetKeyDown(KeyCode.Space) && canShot)
            {
                Instantiate (laser,transform.position,transform.rotation);
                soundManager.SeleccionAudio(2,0.7f);
                 play = true;
                cancold = 0.3f;
                canShot = false;
            }
        }
}
