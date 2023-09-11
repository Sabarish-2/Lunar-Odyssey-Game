using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    //public Transform Transform;
    public PlayerMovement playerMovement;
    public Vector3 offset;

    private void OnCollisionEnter (Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "rock")
        {
            transform.position = transform.position - offset;

            playerMovement.enabled = false;

        }
    }

}
