using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{
    public GameObject panel;

    private void OnTriggerEnter2D(Collider2D other) //포탈에 도달하면 클리어 패널을 킴
    {
        if (other.gameObject.tag == "Player")
        {
            panel.SetActive(true);
            Time.timeScale = 0; //시간을 0으로 설정한다.
        }
    }
}
