using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float helath;
    public enum ControlType { PC, Android };

    public ControlType controlType;
    public Joystick joystick;

    public float speed;
    private Rigidbody2D rb;
    private Vector2 moveInput;
    private Vector2 moveVelocity;

    private Animator anim;
    private bool facingRight = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        if (controlType == ControlType.PC)
        {
            joystick.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (controlType == ControlType.PC)
        {
            moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        }
        else if (controlType == ControlType.Android)
        {
            moveInput = new Vector2(joystick.Horizontal, joystick.Vertical);
        }
        moveVelocity = moveInput.normalized * speed;

        if (moveInput.x == 0)
        {

            anim.SetBool("IsRunning", false);

        }
        else
        {
            anim.SetBool("IsRunning", true);
        }

        if (!facingRight && moveInput.x >0)
        {
            Flip();
        }
        else  if (facingRight && moveInput.x < 0)
        {
            Flip();
        }
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }

    private void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
