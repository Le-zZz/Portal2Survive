using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D body;
    Vector2 movement;
    [SerializeField] float speed = 3;
    [SerializeField] string horizontal;
    [SerializeField] string vertical;

    [SerializeField] Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis(horizontal);
        movement.y = Input.GetAxis(vertical);

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.magnitude);

    }

    private void FixedUpdate()
    {
        body.MovePosition(body.position + movement * speed * Time.fixedDeltaTime);
    }
}
