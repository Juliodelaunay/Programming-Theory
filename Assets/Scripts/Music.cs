using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public static Music instance;
    
    void Start()
    {
         
    {
        if (instance == null)
        { instance = this; 
        DontDestroyOnLoad(gameObject);}
    }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
