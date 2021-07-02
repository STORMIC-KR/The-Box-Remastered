using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public SpriteRenderer playerSPR;

    public GameObject quitPanel;

    void Awake()
    {
        Screen.SetResolution(1920, 1080, true); //1080P
        Application.targetFrameRate = 60;
    }

    public void Mute()
    {
        AudioListener.pause = !AudioListener.pause;
    }

    public void Selector()
    {
        SceneManager.LoadScene("StageSelector");
        Time.timeScale = 1;
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainTitle");
        Time.timeScale = 1;
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    //public void Quit()
    //{
    //    Application.Quit();
    //    Debug.Log("Quit");
    //}

    public void QuitGame()
    {
        quitPanel.SetActive(true);
    }

    public void NotQuit()
    {
        quitPanel.SetActive(false);
    }

    public void ReallyQuit()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }
}
