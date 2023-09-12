using TMPro;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public Rigidbody rigidBody;
    public PlayerMovement playerMovement;
    public Vector3 offset;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI scorePart;

    private void OnCollisionEnter (Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "rock")
        {
            transform.position = transform.position - offset;

            playerMovement.enabled = false;
            PlayerPrefs.SetInt("Active", 0);
            int Score = PlayerPrefs.GetInt("Score");
            PlayerPrefs.SetInt("Score", Score - 50);
            scorePart.text = "Try ";
            scoreText.text = "Again...";

            FindObjectOfType<GameManager>().GameOver();
        }

    }

    private void OnTriggerEnter(Collider collisionInfo)
    {
        if (collisionInfo.tag == "Finish")
        {
            PlayerPrefs.SetInt("Active", 0);
            int Score = PlayerPrefs.GetInt("Score");
            PlayerPrefs.SetInt("Score", Score + 100);
            scorePart.text = "Level";
            scoreText.text = "Complete!";
            rigidBody.velocity = Vector3.zero;
        }
    }

}
