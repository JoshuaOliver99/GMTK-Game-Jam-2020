using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public ColourGameController ColourGameController;
    // Moving
    public Rigidbody2D rb; // For this's rigidbody
    public float MoveSpeed = 4f; // Movement Speed
    int xDirection, yDirection; // For holding player direction

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            xDirection = -1;
        else if (Input.GetKey(KeyCode.D))
            xDirection = 1;
        if (Input.GetKey(KeyCode.W))
            yDirection = 1;
        else if (Input.GetKey(KeyCode.S))
            yDirection = -1;

        rb.velocity = new Vector2(xDirection * MoveSpeed, yDirection * MoveSpeed);

        xDirection = 0;
        yDirection = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Red"))
        {
            ColourGameController.collidedColour = "Red";
            Debug.Log("RED COLLISION");
        }

        if (collision.CompareTag("Green"))
        {
            ColourGameController.collidedColour = "Green";
            Debug.Log("Green COLLISION");
        }

        if (collision.CompareTag("Blue"))
        {
            ColourGameController.collidedColour = "Blue";
            Debug.Log("blue COLLISION");
        }

        if (collision.CompareTag("Pink"))
        {
            ColourGameController.collidedColour = "Pink";
            Debug.Log("Pink COLLISION");
        }

        if (collision.CompareTag("Orange"))
        {
            ColourGameController.collidedColour = "Orange";
            Debug.Log("Orange COLLISION");
        }

        if (collision.CompareTag("Yellow"))
        {
            ColourGameController.collidedColour = "Yellow";
            Debug.Log("Yellow COLLISION");
        }
    }

}
