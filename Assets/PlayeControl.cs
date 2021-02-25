﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayeControl : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 moveInput;
    private Vector2 moveVelocity;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
private bool facingRight = true;
    // Update is called once per frame
    void Update()
    {
        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;
        /*if (!facingRight && moveInput.x > 0)
        {
            Flip();
        }
        else if (facingRight && moveInput.x < 0)
        {
            Flip();
        }*/
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }

    /*private void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }*/
}
