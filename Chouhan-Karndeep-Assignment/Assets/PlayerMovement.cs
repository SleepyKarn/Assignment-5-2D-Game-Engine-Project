using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Movement speed of the player
    public float speed;

    // Horizontal movement input from the player
    private float Move;

    // Jump force applied to the player
    public float jump;

    // Flag to track if the player is currently jumping
    public bool isJumping;

    // Reference to the Rigidbody2D component of the player
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        // Get the Rigidbody2D component attached to the player GameObject
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get horizontal input from the player
        Move = Input.GetAxis("Horizontal");

        // Set the velocity of the player based on the input
        rb.velocity = new Vector2(speed * Move, rb.velocity.y);

        // Check if the player pressed the jump button and is not currently jumping
        if (Input.GetButtonDown("Jump") && isJumping == false)
        {
            // Apply a vertical force to the player to make them jump
            rb.AddForce(new Vector2(rb.velocity.x, jump));
        }
    }

    // This method is called when the player collides with another object
    private void OnCollisionEnter2D(Collision2D other)
    {
        // Check if the collision is with the ground
        if (other.gameObject.CompareTag("Ground"))
        {
            // Set the isJumping flag to false since the player is grounded
            isJumping = false;
        }
    }

    // This method is called when the player stops colliding with another object
    private void OnCollisionExit2D(Collision2D other)
    {
        // Check if the collision was with the ground
        if (other.gameObject.CompareTag("Ground"))
        {
            // Set the isJumping flag to true since the player is no longer grounded
            isJumping = true;
        }
    }
}
