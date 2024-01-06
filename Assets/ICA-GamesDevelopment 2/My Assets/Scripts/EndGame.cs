using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{   
    public int animalCount = 0;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Animal"))
        {
           animalCount++;
        }
    }
    void End() 
    {         
        if (animalCount == 3)
        {
            Debug.Log("You Win");
        }
    }

    private void Update()
    {
        End();
        
    }

}
