using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigidBody;

    public float movementSpeed = 4000f;
    
    public float sideSpeed = 500f;

    // Update is called once per frame for Phy
    void FixedUpdate()
    {
        // Add a forward force
        rigidBody.AddForce(0, 0, movementSpeed * Time.deltaTime);

        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rigidBody.AddForce(-sideSpeed *  Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rigidBody.AddForce(sideSpeed *  Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }


    }
}
