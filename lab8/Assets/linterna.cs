using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linterna : MonoBehaviour
{
    bool flashlightState;
    AudioSource audioSource;
    public AudioClip flashlightStateSound;

   
    void Start()
    {
        flashlightState = true;
        audioSource = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
           
            flashlightState = !flashlightState;
            gameObject.GetComponent<Light>().enabled = flashlightState;
            if (audioSource != null && flashlightStateSound != null)
            {
                audioSource.PlayOneShot(flashlightStateSound);
            }
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }


    }
}
