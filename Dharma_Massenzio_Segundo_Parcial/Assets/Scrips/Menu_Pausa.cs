using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Pausa : MonoBehaviour
{
    public GameObject pause;
    public bool isPaused;

    void Start()
    {
        pause.SetActive(false);
        isPaused = false; 
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resumegame();
            }
            else
            {
                Pausegame();
            }
        }
    }



    public void Pausegame()
    {
        pause.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void Resumegame()
    {
        pause.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void Exit()
    {
        Application.Quit();
    }
}


