using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerControllerYoutube : MonoBehaviour
{
    /*
    // Start is called before the first frame update

    public Camera cam;
    public NavMeshAgent agent;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }

    }*/
    public float moveSpeed = 5.0f;
    private Vector3 targetPosition;
    public LayerMask groundLayer;
    
    void Start()
    {
        targetPosition = transform.position;
    }
    

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, groundLayer))
            {
                targetPosition = hit.point;
                targetPosition.y = transform.position.y;
            }
        }

        float step = moveSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);
    }
}
