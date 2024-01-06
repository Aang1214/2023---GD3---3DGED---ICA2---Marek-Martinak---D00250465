using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    public GameObject pauseObjects;
    // Update is called once per frame
    private void Start()
    {
        Time.timeScale = 0;
    }

    public void PauseGame()
    {
        pauseObjects.SetActive(true);
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        pauseObjects.SetActive(false);
        Time.timeScale = 1;
    }
    public void StartGame()
    { 
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
