using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{

    List<Food> inventory = new List<Food>(); // List to hold the food items
    Food food; // Food object to hold the food type
    // function to add food to the inventory
    void AddItem(Food item)
    {
        inventory.Add(item);
    }

    private void OnTriggerEnter(Collider other) // Called when another collider enters the trigger area of this GameObject
    {
        if (other.gameObject.CompareTag("Food")) // Check if the collider has the tag "Food"
        {
            Food food = other.gameObject.GetComponent<MyFoodType>().food; // Get the food type from the food object
            AddItem(food); // Add the food to the inventory
            Destroy(other.gameObject); // Destroy the food object
            food.foodEvent.Raise(); // Raise the event
        }
    }
}
