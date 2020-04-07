using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadlessZombieBehavior : MonoBehaviour
{
    [SerializeField] Transform startPoint;
    [SerializeField] float force = 2f;
    private Rigidbody2D body;
    private Vector3 lastVelocity;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        body.AddForce(startPoint.up * force, ForceMode2D.Impulse);
    }
}

