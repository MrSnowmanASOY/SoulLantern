using UnityEngine;

public class player_movement : MonoBehaviour 
{
    public float movementSpeed = 1.0f;
    float horizontalInput;
    float verticalInput;
    float xaxis = 0f;
    float zaxis = 0f;
    float yaxis = 1f;

    void Update () 
    {
        //Get user inputs
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        xaxis += horizontalInput;
        zaxis += verticalInput;

        //Update objects position
        transform.position = new Vector3(xaxis, yaxis, zaxis);
    }
}