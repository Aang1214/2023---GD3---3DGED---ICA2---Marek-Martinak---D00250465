using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    // object to hold the pause menu
    public GameObject pauseObjects;
    // Update is called once per frame
    private void Start()
    {
        //Set time to 0, pause time
        Time.timeScale = 0;
    }

    public void PauseGame()
    {
        // Activate the pause objects/UI
        pauseObjects.SetActive(true);
        //Set time to 0, pause time
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        // Deactivate the pause objects/UI
        pauseObjects.SetActive(false);
        //Set time to 1, regular time
        Time.timeScale = 1;
    }
    public void StartGame()
    { 
        //Set time to 1, regular time
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        // Quit the application
        Application.Quit();
        //Display Quit written in the console
        Debug.Log("Quit");
    }
}
