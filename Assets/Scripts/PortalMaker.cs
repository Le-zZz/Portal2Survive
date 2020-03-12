using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalMaker : MonoBehaviour
{
    [SerializeField] Transform spawnPoint;
    [SerializeField] Transform initialPoint;

    [SerializeField] GameObject portal;
    
    //public AudioSource bulletSound;
    
    private bool canShoot = true;
    private bool launchTimer = false;

    private float timeStart = 0f;
    private float time = 0f;
    private float timeEnd = 5f;

    private void Start()
    {
        time = timeStart;
        portal.transform.position = initialPoint.position;
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

        if (time >= timeEnd)
        { 
            launchTimer = false; 
            canShoot = true; 
            time = timeStart;
            portal.transform.position = initialPoint.position;
        }
    }

    public void Shot()
    {
        portal.transform.position = spawnPoint.position;
        canShoot = false; 
        launchTimer = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "redDeadZone")
        {
            canShoot = false;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "redDeadZone")
        {
            canShoot = true;
        }
    }
}
