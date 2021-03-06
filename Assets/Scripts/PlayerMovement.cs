using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    private float moveInput;

    public float speed;
    //public float jumpForce;
    //public float checkRadius;

    //public AudioSource jumpAudio;
    public AudioSource gravityAudio;

    //public float health = 10f;

    //public Transform feetPos;

    //public LayerMask whatIsGround;

    private bool facingRight = true;
    private bool isGround;
    private bool isJumping;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {
        //isGround = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);

        //if (isGround == true && Input.GetKeyDown(KeyCode.Space))
        //{
        //    isJumping = true;
        //    rb.velocity = Vector2.up * jumpForce;
        //    jumpAudio.Play();
        //    Debug.Log("Jump!");
        //}
        //else if (Input.GetKeyUp(KeyCode.Space))
        //{
        //    isJumping = false;
        //}

        if (Input.GetKeyDown(KeyCode.Q))
        {
            rb.gravityScale = -rb.gravityScale;
            gravityAudio.Play();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Portal1"))
        {
            GameObject.FindGameObjectWithTag("Portal1").GetComponent<Portal>().OnPortal1();
        }

        else if (other.CompareTag("Portal2"))
        {
            GameObject.FindGameObjectWithTag("Portal2").GetComponent<Portal>().OnPortal2();
        }
    }
}
