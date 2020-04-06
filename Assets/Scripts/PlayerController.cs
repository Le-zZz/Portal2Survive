using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D body;
    private Vector2 movement;
    private float moveSpeed = 3f;
    [SerializeField] string horizontal;
    [SerializeField] string vertical;

    [SerializeField] private Animator animator;
  
    [SerializeField] GameObject portalSpawn;

    [SerializeField] Vector2 movementDirection;
    [SerializeField] float movementSpeed;

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
        animator.SetFloat("Speed", movement.sqrMagnitude);

        ProcessInputs();
        Portal();
    }

    void FixedUpdate()
    {
        body.MovePosition(body.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    void ProcessInputs()
    {
        movementDirection = new Vector2(Input.GetAxis(horizontal), Input.GetAxis(vertical));
        movementSpeed = Mathf.Clamp(movementDirection.magnitude, 0.01f, 1.0f);
        movementDirection.Normalize();
    }

    void Portal()
    {
        if(movementDirection != Vector2.zero)
        { 
            portalSpawn.transform.localPosition = movementDirection;
        }
    }
}
