using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIChase : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;

    public GameObject player;
    public float speed;

    private float distance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        movement.x = direction.x;
        movement.y = direction.y;

        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
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
    }
}
