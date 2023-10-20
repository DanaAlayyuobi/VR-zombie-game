using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class swanScript : MonoBehaviour
{
    public healthMangerScript healthS;
    public AudioSource ZDeathSound;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log( healthMangerScript.healthCounter);

    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("IS TRIGER1");
        if (other.gameObject.tag == "Ghoul")
        {
            ZDeathSound.Play();
            Debug.Log("zombie diy");

            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Mashroom" && healthMangerScript.healthCounter <4)
        {
            Debug.Log("mashroom" + healthMangerScript.healthCounter);
            healthMangerScript.healthCounter++;

        } 

    }
    
}
