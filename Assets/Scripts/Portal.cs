using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{

    [SerializeField] private float time = 5;
    

    void Update()
    {
        Destroy(gameObject, time);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "player")
        {
            Destroy(gameObject);
        }
    }
}
