using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeChange : MonoBehaviour
{
    public GameObject LoosePicture; // Input loose picture in the inspector
    public GameObject GlobalLight; // Input global light in the inspector
    public float speed = 1; // Speed in the inspector
    // Update is called once per frame
    void Update()
    {
        GlobalLight.transform.Rotate(Vector3.right * speed * Time.deltaTime); // Rotate the global light
        if (GlobalLight.transform.rotation.eulerAngles.x <= 5) // Check if the rotation is less than 5
        {
            Debug.Log("You Lose"); // Display "You Lose" in the console
            LoosePicture.SetActive(true); // Activate the loose picture
            StartCoroutine(WaitASec()); // Start a coroutine to wait for 2 seconds before quitting the application
        }
    }

    private IEnumerator WaitASec()
    {
        // Wait for 2 seconds
        yield return new WaitForSeconds(2);

        // Quit the application
        Application.Quit();
    }
}
