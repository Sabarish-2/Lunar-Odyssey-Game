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
        Debug.Log("You Did It!");
        Invoke("NextLevel", RestartDelay);

    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void GameOver()
    {
        if (GameEnd == false)
        {
            GameEnd = true;

            //Quiz
            Invoke("Restart", RestartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
