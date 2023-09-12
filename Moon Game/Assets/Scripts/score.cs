using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;
    private int Score = 0;
    void Start()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;

        if (currentSceneName == "Level 01")
        {
            PlayerPrefs.SetInt("Score", 0);
            PlayerPrefs.SetInt("Active", 1);
            PlayerPrefs.Save();
            Score = 0;
            //Debug.Log(PlayerPrefs.GetInt("Score"));
        }
        else
        {
            //Debug.Log(PlayerPrefs.GetInt("Score"));
            Score = PlayerPrefs.GetInt("Score");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Active") == 1)
        {
            scoreText.text = (Score + (player.position.z - 10) / 5).ToString("0");
            int number;
            if (int.TryParse(scoreText.text, out number))
            {
                PlayerPrefs.SetInt("Score", number);
            }
        }
    }
}
