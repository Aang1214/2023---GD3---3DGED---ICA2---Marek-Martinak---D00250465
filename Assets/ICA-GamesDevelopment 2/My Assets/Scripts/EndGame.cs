using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class EndGame : MonoBehaviour
{
    // Input win picture in the inspector
    public GameObject WinPicture;

    // Count the number of animals in the trigger area
    public int animalCount = 0;

    // OnTriggerEnter method to check if the collider has entered the trigger area
    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider has a tag "Animal"
        if (other.CompareTag("Animal"))
        {
            // Increment the animalCount
            animalCount++;

            // Check if the win condition is met whenever an animal is counted
            End();
        }
    }

    // Method to check if the win condition is met
    void End()
    {
        // Check if the animalCount has reached 3
        if (animalCount == 3)
        {
            // Activate the WinPicture GameObject
            WinPicture.SetActive(true);

            // Start a coroutine to wait for 2 seconds before quitting the application
            StartCoroutine(WaitASec());

            
        }
    }

    // Coroutine to wait for 2 seconds and then quit the application
    private IEnumerator WaitASec()
    {
        // Wait for 2 seconds
        yield return new WaitForSeconds(2);

        // Quit the application
        Application.Quit();

    }
}
