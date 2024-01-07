using GD;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Food", menuName = "Food")]
public class Food : ScriptableObject
{
    public string foodName; // Name of the food
    public string description; // Description of the food
    public Sprite artwork; // Artwork of the food
    public string type; // Type of the food
    public GameEvent foodEvent; // Event that is triggered when the food is triggered
}
