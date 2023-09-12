using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameEnd = false;

    public float RestartDelay= 1f;

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
