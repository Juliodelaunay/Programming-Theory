using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip [] sounds;
    AudioSource controlAudio;

    void Start()
    {
         controlAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SeleccionAudio (int indice,float volumen)
    {
        controlAudio.PlayOneShot(sounds[indice], volumen);
    }
}
