using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{

    private GameObject exit = null;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "redPortal")
        {
            exit = GameObject.FindWithTag("blueTransform");
            transform.position = exit.transform.position;
        }
        
        if (other.gameObject.tag == "bluePortal")
        {
            exit = GameObject.FindWithTag("redTransform");
            transform.position = exit.transform.position;
        }
    }
}
