using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityCoin : MonoBehaviour
{
    public GameObject gravityBtn;
    public GameObject coin;

    public AudioSource coinSound;

    void Start()
    {
        gravityBtn.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other) //포탈에 도달하면 클리어 패널을 킴
    {
        if (other.CompareTag("Player"))
        {
            coinSound.Play();
            gravityBtn.SetActive(true);
            coin.SetActive(false);
        }
    }
}
