using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerMovement : MonoBehaviour
{
    
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;
    
    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical",movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        //tansform local scale to x -1 when moving left
        if (movement.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        //transform local scale to x 1 when moving right
        else if (movement.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

        //fix for diagonal movement faster than normal movement
        if (movement.x != 0 && movement.y != 0)
        {
            moveSpeed = 4f;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift) && movement.x != 0 && movement.y != 0)
        {
            moveSpeed = 10f;
        }
        else if (Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = 7f;
        }
        else
        {
            moveSpeed = 5f;
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
