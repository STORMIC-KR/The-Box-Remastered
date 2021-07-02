using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClickON : MonoBehaviour
{
    public GameObject offObj;

    SpriteRenderer btnrenderer;

    public AudioSource click;
    void Start()
    {
        btnrenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision) //버튼머리 콜라이더에 닿자마자
    {
        this.transform.localPosition = new Vector3(0f, -0.2f, 0f); //위치 0, -0.2, 0으로 옮기고,
        offObj.SetActive(true); //숨겨져있는 오브젝트 나타나게하고,
        click.Play(); //클릭소리 나게하고,
        btnrenderer.color = new Color(255, 0, 0, 255); //버튼머리 색상 빨간색으로 바꾼다.
    }
}
