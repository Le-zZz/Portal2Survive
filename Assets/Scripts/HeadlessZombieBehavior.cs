using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadlessZombieBehavior : MonoBehaviour
{
 
    Rigidbody2D body;
    [SerializeField] float force = 2f;

    [SerializeField] Transform startPoint;

    Vector3 lastVelocity;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        body.AddForce(startPoint.up * force, ForceMode2D.Impulse);
    }

}

