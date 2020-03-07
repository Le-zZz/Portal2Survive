using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalMaker : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject portalPrefab;
    
    //public AudioSource bulletSound;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Shot();
        }
    }

    public void Shot()
    {
        GameObject bullet = Instantiate(portalPrefab, spawnPoint.position, spawnPoint.rotation); 
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>(); 
        
    }
}
