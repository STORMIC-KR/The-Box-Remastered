using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaDamage : MonoBehaviour
{
    public GameObject deadPanel;

    void OnTriggerEnter2D(Collider2D other) //콜라이더에 닿자마자
    {
        if (other.CompareTag("Player") || other.CompareTag("Player2")) 
        {
            deadPanel.SetActive(true); //데스패널 띄우고,
            Time.timeScale = 0; //시간을 0으로 설정한다.
        }
    }
}
