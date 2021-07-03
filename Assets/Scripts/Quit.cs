using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    public GameObject quitPanel;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePanel();
        }
    }

    void TogglePanel()
    {
        bool currentState = quitPanel.activeSelf;
        quitPanel.SetActive(!currentState);
    }
}
