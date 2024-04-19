using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScript : MonoBehaviour
{
    // Reference to the starting point GameObject
    public GameObject startPoint;

    // Reference to the player GameObject
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // This method is called when the object collides with another object
    private void OnCollisionEnter2D(Collision2D other)
    {
        // Check if the collision is with the player object
        if (other.gameObject.CompareTag("Player"))
        {
            // If player collides, reset its position to the starting point
            Player.transform.position = startPoint.transform.position;
        }
    }
}
