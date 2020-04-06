using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{

    [SerializeField] GameObject exitRed;
    [SerializeField] GameObject exitBlue;
    [SerializeField] GameObject defaultSpawn;

    [SerializeField] string wrongCageColor;


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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag  == "deadZone")
        {
            transform.position = defaultSpawn.transform.position;
        }

        if (collision.gameObject.tag == wrongCageColor)
        {
            transform.position = defaultSpawn.transform.position;
        }
    }
}
