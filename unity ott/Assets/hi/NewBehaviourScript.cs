using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public float jumpForce = 3.0f;
    public float moveSpeed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector2 moveDirection = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);
        rb.velocity = moveDirection;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            jump();
        else if (collision.gameObject.CompareTag("Ground1"))
            jump(12);
    }
    void jump()
    {
        rb.velocity = Vector2.up * jumpForce;
    }
    void jump(float j)
    {
        rb.velocity = Vector2.up * j;
    }





}

