using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//using UnityEngine.UI;


public class healthMangerScript : MonoBehaviour
{
    public static float healthCounter=4.0f;
    public Image gameOver;
    public AudioSource Sound;
    public Image healthBar;
    public AudioClip gamwOverSound,hitSound;
   public swanScript swanS;
    //public AudioSource playingSound;

    void Start()
    {
        healthBar.fillAmount = healthCounter / 4.0f;

        Time.timeScale = 1;
        gameOver.enabled = false;
       // playingSound.Play();

    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(healthCounter+"healthMAngerScript");
        healthBar.fillAmount = healthCounter / 4.0f;


    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Ghoul")
        {
            healthCounter--;
            Debug.Log("player heart"+ healthCounter);
            Sound.clip = hitSound;
            Sound.Play();
              healthBar.fillAmount = healthCounter / 4.0f;
            if (healthCounter <= 0)
            {
                Sound.clip = gamwOverSound;

                Sound.Play();

                Debug.Log("player diy");
                Destroy(gameObject);
                gameOver.enabled = true;
                Time.timeScale = 0;


            }
           

        }
    }
    
 
}
