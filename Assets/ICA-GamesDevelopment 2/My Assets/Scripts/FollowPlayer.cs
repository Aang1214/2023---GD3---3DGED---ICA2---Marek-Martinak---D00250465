using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using GD;
using UnityEngine.Events;
using UnityEngine.Audio;

public class FollowPlayer : MonoBehaviour
{
    // Audio sources for different states
    public AudioSource animalHappy; // Sound when the animal is happy
    public AudioSource animalMad; // Sound when the animal is mad

    // Flags to determine the state of the animal
    public bool food = false; // Indicating whether the animal has food
    public bool isFollowing = false; // Indicating whether the animal is following the player

    // This method is called when another collider enters the trigger area of this GameObject
    public void OnTriggerEnter(Collider other)
    {
        // Check if the collider has the tag "Player" and the animal has food
        if (other.gameObject.tag == "Player" && food)
        {
            // The animal starts following the player and plays a happy sound
            isFollowing = true;
            animalHappy.Play();
        }
        // Check if the collider has the tag "Player" and the animal doesn't have food
        else if (other.gameObject.tag == "Player" && !food)
        {
            // The animal stops following and plays a mad sound
            isFollowing = false;
            animalMad.Play();
        }

        // Check if the collider has the tag "Fence"
        if (other.gameObject.tag == "Fence")
        {
            // The animal stops following, doesn't have food, and disables its own collider
            isFollowing = false;
            food = false;
            GetComponent<BoxCollider>().enabled = false;
        }
    }

    // Called when the animal picks up food
    public void OnFoodPickUp()
    {
        food = true; // Set the food flag to true
    }

    private void Update()
    {
        // Check if isFollowing is true
        if (isFollowing)
        {
            // Set the destination of the NavMeshAgent to the position of the player
            GetComponent<NavMeshAgent>().SetDestination(GameObject.FindGameObjectWithTag("Player").transform.position);
        }
    }
}
