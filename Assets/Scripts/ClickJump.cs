using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickJump : MonoBehaviour
{
    Rigidbody2D rigid;
    private float jumpPower = 6.5f;
    bool isjumping;
    public AudioSource jump;

    void OnMouseDown()
    {
        if (isjumping == false)
        {
            rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            isjumping = true;
            jump.Play();
        }
    }
}
