using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSelector : MonoBehaviour
{
    public GameObject stage1Panel;
    public GameObject stage2Panel;
    public GameObject stage3Panel;

    public void panel1On()
    {
        stage1Panel.SetActive(true);
    }

    public void panel2On()
    {
        stage2Panel.SetActive(true);
    }

    public void panel3On()
    {
        stage3Panel.SetActive(true);
    }

    public void panel1Off()
    {
        stage1Panel.SetActive(false);
    }

    public void panel2Off()
    {
        stage2Panel.SetActive(false);
    }

    public void panel3Off()
    {
        stage3Panel.SetActive(false);
    }
}
