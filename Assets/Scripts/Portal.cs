using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TestTools;

public class Portal : MonoBehaviour
{
    [SerializeField] GameObject portal; 
    [SerializeField] Transform initialPoint;
    [SerializeField] string zoneNameTag;
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == zoneNameTag)
        {
            portal.transform.position = initialPoint.position;
        }
    }
}
