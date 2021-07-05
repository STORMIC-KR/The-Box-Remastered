using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    GameObject player;
    GameObject portal1;
    GameObject portal2;

    void Start()
    {
        portal1 = GameObject.FindGameObjectWithTag("Portal1");
        portal2 = GameObject.FindGameObjectWithTag("Portal2");

        player = GameObject.Find("Player");
    }

    public void OnPortal1()
    {
        player.transform.position = new Vector3(portal2.transform.position.x+2, 0, 0);
    }

    public void OnPortal2()
    {
        player.transform.position = new Vector3(portal1.transform.position.x+2, 0, 0);
    }
}
