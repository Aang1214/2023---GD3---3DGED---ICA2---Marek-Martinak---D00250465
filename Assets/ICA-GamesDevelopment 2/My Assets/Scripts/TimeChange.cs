using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeChange : MonoBehaviour
{
    public GameObject GlobalLight;
    public float speed = 1;
    // Update is called once per frame
    void Update()
    {
        GlobalLight.transform.Rotate(Vector3.right * speed * Time.deltaTime);
        if (GlobalLight.transform.rotation.eulerAngles.x <= 5)
        {
            Debug.Log("You Lose");
        }
    }
}
