using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalMaker : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject portalPrefab;
    
    //public AudioSource bulletSound;
    
    private bool canShoot = true;
    private bool launchTimer = false;

    private float timeStart = 0f;
    private float time = 0f;
    private float timeEnd = 5f;

    private void Start()
    {
        time = timeStart;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (canShoot)
            {
                Shot();
            }
        }

        if (launchTimer)
        {
            time += Time.deltaTime;
        }

        if (time == timeEnd)
        { 
            launchTimer = false; 
            canShoot = true; 
            time = timeStart; 
        }
        
        
    }

    public void Shot()
    {
        GameObject bullet = Instantiate(portalPrefab, spawnPoint.position, spawnPoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>(); 
        canShoot = false; 
        launchTimer = true;
    }
}
