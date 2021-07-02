using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausePanel;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) //esc 누르면 일시정지 패널을 킴
        {
            pausePanel.SetActive(true); //일시정지 패널을 켜라
            Time.timeScale = 0;
            Debug.Log("loading PausePanel");
            //음악 정지 기능 넣을 예정
        }
    }

    public void LoadPauseMenu()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void Resume()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void Menu()
    {
        pausePanel.SetActive(false);
        SceneManager.LoadScene("MainTitle");
        Time.timeScale = 1;
    }
}
