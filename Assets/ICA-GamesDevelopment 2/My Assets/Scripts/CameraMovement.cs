using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraMovement : MonoBehaviour
{
    public float speed = 5.0f; // Movement speed
    public float rotationSpeed = 50.0f; // Rotation speed

    private Quaternion initialRotation;

    void Start()
    {
        // Store the initial rotation of the camera
        initialRotation = transform.rotation;
    }

    void Update()
    {
        // Check for input from the Q and E keys to rotate the camera
        if (Input.GetKey(KeyCode.Q))
        {
            RotateCamera(-rotationSpeed * Time.deltaTime); // Rotate left
        }
        else if (Input.GetKey(KeyCode.E))
        {
            RotateCamera(rotationSpeed * Time.deltaTime); // Rotate right
        }

        // Get user input for movement
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0.0f, vertical);

        // Convert the input direction from local to world space
        direction = transform.TransformDirection(direction);

        // Apply movement based on the transformed direction
        transform.position += direction * speed * Time.deltaTime;
    }

    void RotateCamera(float rotateAmount)
    {
        // Rotate the camera around the Y-axis
        transform.Rotate(Vector3.up, rotateAmount);

        // Maintain the initial X and Z rotations
        Vector3 euler = transform.eulerAngles;
        euler.x = initialRotation.eulerAngles.x;
        euler.z = initialRotation.eulerAngles.z;
        transform.rotation = Quaternion.Euler(euler);
    }
}
