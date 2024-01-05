using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using GD;
using UnityEngine.Events;

public class FollowPlayer : MonoBehaviour
{
    public bool food = false;
    public bool isFollowing = false;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && food)
        {
            isFollowing = true;
       
            Debug.Log("Player has entered the trigger");
        }

        if (other.gameObject.tag == "Fence")
        {
            isFollowing = false;
            food = false;
           
            Debug.Log("Player has entered the trigger");
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
