using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghoulScript : MonoBehaviour
{
    public float moveSpeed = .002f; // Adjust this to set the player's movement speed.
    public GameObject gholePrefab; // Reference to the ghole prefab.
    int ghoulCounter = 0;
    private Rigidbody rb;
    public Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 spawnPosition = new Vector3(Random.Range(-33f, 140f), -10.93f, Random.Range(-11f, 46f));
      if (ghoulCounter <4) {

            // Instantiate the ghole prefab at the chosen position.
           Instantiate(gholePrefab, spawnPosition, Quaternion.identity);
            ghoulCounter++;
            Debug.Log(ghoulCounter);
        
        }
      
    }
}

