using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public Rigidbody rigidBody;
    public PlayerMovement playerMovement;
    public Vector3 offset;

    private void OnCollisionEnter (Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "rock")
        {
            transform.position = transform.position - offset;

            playerMovement.enabled = false;

            FindObjectOfType<GameManager>().GameOver();
        }

    }

    private void OnTriggerEnter(Collider collisionInfo)
    {
        if (collisionInfo.tag == "Finish")
        {
            //Debug.Log("Ok");
            rigidBody.velocity = Vector3.zero;
        }
    }

}
