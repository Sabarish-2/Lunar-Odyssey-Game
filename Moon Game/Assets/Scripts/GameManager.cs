using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameEnd = false;
    bool isPaused = false;


    public float RestartDelay= 1f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            TogglePause();
        }

        if (isPaused)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                RestartLevel();
                TogglePause();
            }

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                QuitGame();
            }
        }
    }

    void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0f; // Pause the game by setting time scale to 0
        }
        else
        {
            Time.timeScale = 1f; // Resume the game by setting time scale back to 1
        }
    }

    void RestartLevel()
    {
        PlayerPrefs.SetInt("Active", 1);  // Y?
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void QuitGame()
    {
        Application.Quit();
    }

    public void LevelEnd()
    {
        //Debug.Log("You Did It!");
        Invoke("NextLevel", RestartDelay);

    }

    public void NextLevel()
    {
        PlayerPrefs.SetInt("Active", 1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void GameOver()
    {
        if (GameEnd == false)
        {
            GameEnd = true;
            Invoke("Restart", RestartDelay);
        }
    }

    void Restart()
    {   
        PlayerPrefs.SetInt("Active", 1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
