using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{

    [SerializeField] GameObject exitRed;
    [SerializeField] GameObject exitBlue;


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
            transform.position = exitBlue.transform.position;
        }
        
        if (other.gameObject.tag == "bluePortal")
        {
            transform.position = exitRed.transform.position;
        }
    }
}
