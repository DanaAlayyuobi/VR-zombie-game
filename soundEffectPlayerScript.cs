using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundEffectPlayerScript : MonoBehaviour
{
   public AudioSource BGSound;
    void Start()
    {
        BGSound.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
