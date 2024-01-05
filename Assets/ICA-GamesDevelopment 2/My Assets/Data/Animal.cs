using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Animal", menuName = "Animal")]
public class Animal : ScriptableObject
{
    public string animalName;
    public string description;
    public Sprite artwork;
    public int health;
    public int attack;
    public int charm;
}
