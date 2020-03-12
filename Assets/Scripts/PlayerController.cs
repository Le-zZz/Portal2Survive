using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    enum Player
    {
        ONE,
        TWO
    }

    private Player player = Player.ONE;
    private Rigidbody2D body;
    [SerializeField] float movementX = 5;
    [SerializeField] float movementY = 5;
    [SerializeField] float speed = 3;
    
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (player)
        {
            case Player.ONE:
                movementX = Input.GetAxis("HorizontalOne");
                movementY = Input.GetAxis("VerticalOne");
                break;
            case Player.TWO:
                movementX = Input.GetAxis("HorizontalTwo");
                movementY = Input.GetAxis("VerticalTwo");
                break;
        }

        
        body.velocity = new Vector2(movementX * speed, movementY * speed);
        
        
    }
}
