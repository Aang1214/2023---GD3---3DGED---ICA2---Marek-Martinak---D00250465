using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MyPlayerController : MonoBehaviour
{
    
    public float moveSpeed = 5.0f;
    private Vector3 targetPosition;
    public LayerMask groundLayer;
    public NavMeshAgent agent;
    public Animator animator;
    public AudioSource walkingsound;
    void Start()
    {
        targetPosition = transform.position; //set the target position to the player position
    }
    

    void Update()
    {
        if (Input.GetMouseButton(0)) //if the left mouse button is pressed
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //create a ray from the camera to the mouse position
            RaycastHit hit; //a raycast hit variable
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, groundLayer)) //if the raycast hits something on the ground layer
            {
                targetPosition = hit.point; //set the target position to the hit point
                targetPosition.y = transform.position.y; // set the target position y to the same as the player so the player does not move up or down
               
            }
            
        }
        
        agent.SetDestination(targetPosition); //set the destination of the navmesh agent to the target position
        animator.SetFloat("velocity", agent.velocity.magnitude); //set the velocity parameter in the animator to the magnitude of the navmesh agent velocity
        if (agent.velocity.magnitude > 0.3f && !walkingsound.isPlaying) //if the player is moving and the walking sound is not playing
        {
            walkingsound.Play(); //play the walking sound
        }
        else if (agent.velocity.magnitude < 0.1f) //if the player is not moving
        {
            walkingsound.Stop(); //stop the walking sound
        }
       
    }
}
