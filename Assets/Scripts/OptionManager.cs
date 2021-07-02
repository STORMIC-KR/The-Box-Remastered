using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionManager : MonoBehaviour
{
    public GameObject optionPanel;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OptionOn()
    {
        optionPanel.SetActive(true);
    }

    public void OptionOff()
    {
        optionPanel.SetActive(false);
    }
}
