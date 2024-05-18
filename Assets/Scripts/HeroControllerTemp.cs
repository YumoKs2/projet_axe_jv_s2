using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroControllerTemp : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private float horizontalMove;

    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        Move(horizontalMove);

        if (horizontalMove < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (horizontalMove > 0)
        {
            spriteRenderer.flipX = false;
        }
    }

    void Move(float move)
    {
        Vector2 movement = new Vector2(move * moveSpeed, rb.velocity.y);
        rb.velocity = movement;
        animator.SetBool("isRunning", move != 0);
    }
}