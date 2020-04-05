using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadlessZombieBehavior : MonoBehaviour
{
    Rigidbody2D rb;
    public Transform defaultSpawn;

    float bulletForce = 1f;

    bool canWalk = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        CheckZombie();
    }
    public void CheckZombie()
    {

        if (canWalk)
        {
            rb.AddForce(defaultSpawn.up * bulletForce, ForceMode2D.Impulse);
            canWalk = false;
        }
    }
}

