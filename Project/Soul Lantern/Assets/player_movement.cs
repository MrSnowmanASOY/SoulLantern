using UnityEngine;

public class player_movement : MonoBehaviour 
{
    public float movementSpeed = 0.25f;
    float horizontalInput;
    float verticalInput;
    float xaxis = 0f;
    float zaxis = 0f;
    float yaxis = 0.5f;

    void Update () 
    {
        //Get user inputs
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        xaxis += horizontalInput * movementSpeed;
        zaxis += verticalInput * movementSpeed;

        //Update objects position
        transform.position = new Vector3(xaxis, yaxis, zaxis);
    }
}