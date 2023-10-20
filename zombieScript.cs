using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;
//using UnityEngine.UI;

public class zombieScript : MonoBehaviour
{
    public GameObject zombieprefab;
    private Transform player;
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //  transform.Translate(Vector3.forward * 1f * Time.deltaTime);
        player = GameObject.FindGameObjectWithTag("Player").transform;

        transform.position = Vector3.MoveTowards(transform.position, player.position, .02f);
        //Debug.Log(player.transform.position);


    }
   

}
