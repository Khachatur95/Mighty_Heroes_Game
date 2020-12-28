using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    public float jumpForce;
    private float moveInput;

    private Rigidbody2D rb;

    private bool facingRight = true;

    private bool IsGrounded;
    public Transform groundcheck;
    private float checkRadius = 0.5f;
    public LayerMask whatIsGround;

    private int extraJumps;
    public int extraJumpsValue;


    private void Update()
    {
        if (IsGrounded == true)
        {
            extraJumps = extraJumpsValue;
        }


        if (Input.GetKeyDown(KeyCode.UpArrow) && extraJumps > 0 )
        {
            rb.velocity = Vector2.up * jumpForce;
            extraJumps--;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && extraJumps == 0 && IsGrounded == true)
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    private void Start()
    {
        extraJumps = extraJumpsValue;
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        IsGrounded = Physics2D.OverlapCircle(groundcheck.position, checkRadius, whatIsGround);


        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if (facingRight == false && moveInput > 0)
        {
            Flip();
        }
        else if (facingRight == true && moveInput < 0)
        {
            Flip();
        }
    }
    private void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

}
