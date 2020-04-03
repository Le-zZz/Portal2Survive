using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D body;
    [SerializeField] float movementX = 5;
    [SerializeField] float movementY = 5;
    [SerializeField] float speed = 3;
    [SerializeField] string horizontal;
    [SerializeField] string vertical;


    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movementX = Input.GetAxis(horizontal);
        movementY = Input.GetAxis(vertical);

        body.velocity = new Vector2(movementX * speed, movementY * speed);
    }
}
