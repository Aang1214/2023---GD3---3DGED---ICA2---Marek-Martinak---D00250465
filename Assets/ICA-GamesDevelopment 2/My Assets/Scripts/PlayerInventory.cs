using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{

    List<Food> inventory = new List<Food>();
    Food food;
    void AddItem(Food item)
    {
        inventory.Add(item);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Food"))
        {
            Food food = other.gameObject.GetComponent<MyFoodType>().food;
            AddItem(food);
            Destroy(other.gameObject);
            food.foodEvent.Raise();
        }
    }
}
