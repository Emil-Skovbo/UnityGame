using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameisPaused = false;

    public GameObject pausemenuUI;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            BladeModeScript.active = false;
            Cursor.lockState = CursorLockMode.None;
            
            if (GameisPaused)
            {
                Resume();

            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pausemenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameisPaused = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        BladeModeScript.active = true;

    }

    void Pause()
    {
        pausemenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameisPaused = true;
        
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        BladeModeScript.active = true;
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        
        Application.Quit();
    }
}
