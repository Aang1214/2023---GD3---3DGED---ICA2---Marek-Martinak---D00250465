using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using GD;
using UnityEngine.Events;
using UnityEngine.Audio;

public class FollowPlayer : MonoBehaviour
{
    public AudioSource animalHappy;
    public AudioSource animalMad;
    public bool food = false;
    public bool isFollowing = false;
    //public bool isMad = true;
    public void OnTriggerEnter(Collider other)
    {
        /*if (other.gameObject.tag == "Player" && isMad)
        {
            animalMad.Play();
        }*/
        if (other.gameObject.tag == "Player" && food)
        {
            isFollowing = true;
            animalHappy.Play();
            //isMad = false;
            
        }

        else if (other.gameObject.tag == "Player" && !food)
        {
            isFollowing = false;
            animalMad.Play();
        }

        if (other.gameObject.tag == "Fence")
        {
            isFollowing = false;
            food = false;
            GetComponent<BoxCollider>().enabled = false;
            
        }


    }
    
    public void OnFoodPickUp()
    {
        food = true;
    }
    private void Update()
    {
        if (isFollowing)
        {
            GetComponent<NavMeshAgent>().SetDestination(GameObject.FindGameObjectWithTag("Player").transform.position);
        }

        
    }
}
