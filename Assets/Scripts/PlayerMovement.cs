using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 6f;
    public float jumpPower = 5f;

    Rigidbody2D rigid;
    SpriteRenderer rend;

    float horizontal;

    bool isjumping;

    public AudioSource jump;

    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        rigid = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Jump();
        Move();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isjumping = false;
        }

        if (other.gameObject.tag == "JumpPad")
        {
            rigid.AddForce(Vector2.up * jumpPower * 1.5f, ForceMode2D.Impulse);
            Debug.Log("Collide!");
        }
    }

    //void OncollisionEnter2D(Collision2D other)
    //{
    //    if (other.gameObject.tag == "JumpPad")
    //    {
    //        rigid.AddForce(Vector2.up * 10);
    //    }
    //}

    void Jump() //점프
    {
        if(Input.GetButtonDown("Jump"))
        {
            if(isjumping == false)
            {
                rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
                isjumping = true;
                jump.Play();
            }
        }
    }

    public void JumpMobile()
    {
        if (isjumping == false)
        {
            rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            isjumping = true;
            jump.Play();
        }
        //else return;
    }

    void Move() //플레이어 움직임
    {
        float axis = SimpleInput.GetAxisRaw("Horizontal");
        //horizontal = SimpleInput.GetAxisRaw("Horizontal");
        if (axis != 0)
        {
            if (axis > 0) //right
            {
                //rend.flipX = true;
                transform.localScale = new Vector3(1, 1, 1);
            }
            else if(horizontal < 0) //left
            {
                transform.localScale = new Vector3(-1, 1, 1);
                //rend.flipX = false;
            }
        }
        rigid.velocity = new Vector2(moveSpeed * axis, rigid.velocity.y);
    }

    public void NoGravity()
    {
        rigid.gravityScale = 0;
    }

    public void GetGravity()
    {
        rigid.gravityScale = 1;
    }
}
