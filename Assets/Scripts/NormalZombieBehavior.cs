using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalZombieBehavior : MonoBehaviour
{
    [SerializeField] private Transform player1;
    [SerializeField] private Transform player2;
    private Rigidbody2D body;

    private int playerDistance = 10;
    private float speed = 1f;

    private bool followPlayer1 = false;
    private bool followPlayer2 = false;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (followPlayer1)
        {
            var direction = Vector3.Distance(transform.position, player1.transform.position);

            if (direction < playerDistance)
            {
                body.velocity = (player1.transform.position - transform.position).normalized * speed;
            }
        }
        if (followPlayer2)
        {
            var direction = Vector3.Distance(transform.position, player2.transform.position);

            if (direction < playerDistance)
            {
                body.velocity = (player2.transform.position - transform.position).normalized * speed;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "leftSide")
        {
            followPlayer1 = true;
        }
        if (collision.gameObject.tag == "rightSide")
        {
            followPlayer2 = true;
        }
    }
}
