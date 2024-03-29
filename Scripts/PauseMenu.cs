using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GamePause = false;
    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePause)
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

        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        Debug.Log("resume");
        GamePause = false;
    }
    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GamePause = true;
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        Debug.Log("LOADING MENU...");
        SceneManager.LoadScene(0);

    }
    public void Quit()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
