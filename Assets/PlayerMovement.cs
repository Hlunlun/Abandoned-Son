using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 5f;
    float horizontalMove = 0f;
    private bool facingRight = true;
    //
    public Animator anim1,anim2;
    bool grounded = false;
    public Transform groundcheck;
    private float jumpForce = 500f;
    public Rigidbody2D rb { get; set; }
    public bool dead = true;
    bool attack = false;
    float groundRadius = 0.2f;
    public LayerMask whatIsGround;


    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().freezeRotation = true;
        rb = GetComponent<Rigidbody2D>();
        anim1.SetBool("Dead", true);
        anim1.SetFloat("Speed", 0);
        anim2.SetBool("Dead", true);
        anim2.SetFloat("Speed", 0);
        dead = true;
        //anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleInput();
     
    }
    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundcheck.position, groundRadius, whatIsGround);
        anim1.SetBool("Ground", grounded);
        anim2.SetBool("Ground", grounded);

        float horizontal = Input.GetAxis("Horizontal");
        Debug.Log(grounded);
        if (!dead && !attack)
        {
            anim1.SetFloat("vSpeed", rb.velocity.y);
            anim1.SetFloat("Speed", Mathf.Abs(horizontal));
            anim2.SetFloat("vSpeed", rb.velocity.y);
            anim2.SetFloat("Speed", Mathf.Abs(horizontal));
            rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
        }
        if (horizontal > 0 && !facingRight && !dead && !attack)
        {
            Flip(horizontal);
        }

        else if (horizontal < 0 && facingRight && !dead && !attack)
        {
            Flip(horizontal);
        }
    }

    private void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.LeftAlt) && !dead)
        {
            attack = true;
            anim1.SetBool("Attack", true);
            anim1.SetFloat("Speed", 0);
            anim2.SetBool("Attack", true);
            anim2.SetFloat("Speed", 0);

        }
        if (Input.GetKeyUp(KeyCode.LeftAlt))
        {
            attack = false;
            anim1.SetBool("Attack", false);
            anim2.SetBool("Attack", false);
        }

        if (grounded && Input.GetKeyDown(KeyCode.Space) && !dead)
        {
            anim1.SetBool("Ground", false);
            anim2.SetBool("Ground", false);
            rb.AddForce(new Vector2(0, jumpForce));
        }

        //dead animation for testing//
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("ZZZZZZZZZ");
            if (!dead)
            {
                anim1.SetBool("Dead", true);
                anim1.SetFloat("Speed", 0);
                anim2.SetBool("Dead", true);
                anim2.SetFloat("Speed", 0);
                dead = true;
            }
            else
            {
                anim1.SetBool("Dead", false);
                anim2.SetBool("Dead", false);
                dead = false;
            }
        }
    }
    private void Flip(float horizontal)
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
