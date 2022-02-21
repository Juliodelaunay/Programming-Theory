using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class LifePlayer : MonoBehaviour
{
    public float life = 100f;
    public Image barraDeVida;
    public GameObject panelShield;
   
    // EVENTS
    //public static event Action onDeath;
   


    // Start is called before the first frame update
    void Start()
    {
       
        panelShield.SetActive(true);
    }





    // Update is called once per frame
    void Update()
    {
        life = Mathf.Clamp(GameManager.Shield, 0, 100);
        barraDeVida.fillAmount = life / 10;
    }
    
   /*   void OnTriggerEnter(Collider collider)

    { 
       //     if (collider.gameObject.CompareTag("Enemy"))
        //{ life = life - 8; }
                
                if (life <= 0)
        {
            Debug.Log("Life Player llama onDeath");
            onDeath?.Invoke();
        }


    }*/
}