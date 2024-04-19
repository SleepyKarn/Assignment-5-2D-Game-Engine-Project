using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        // Hide the cursor when the game starts
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the Escape key is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // If the pause menu is not active, pause the game
            if (!pauseMenu.activeSelf)
            {
                Time.timeScale = 0f; // Stop time
                pauseMenu.SetActive(true); // Show pause menu
                Cursor.visible = true; // Show cursor
            }
            else // If the pause menu is already active, resume the game
            {
                Time.timeScale = 1f; // Resume time
                pauseMenu.SetActive(false); // Hide pause menu
                Cursor.visible = false; // Hide cursor
            }
        }
    }

    // Quit the application
    public void Quit()
    {
        Application.Quit();
    }

    // Resume the game
    public void Resume()
    {
        Time.timeScale = 1f; // Resume the game
        pauseMenu.SetActive(false); // Hide pause menu
        Cursor.visible = false; // Hide cursor
    }
}
