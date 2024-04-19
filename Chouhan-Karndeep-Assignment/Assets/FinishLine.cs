using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
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
            // Load the next level when the player reaches the finish line
            SceneManager.LoadScene("Level 2");
        }
    }
}
