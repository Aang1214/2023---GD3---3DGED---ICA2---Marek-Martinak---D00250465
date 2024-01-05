using GD;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Food", menuName = "Food")]
public class Food : ScriptableObject
{
    public string foodName;
    public string description;
    public Sprite artwork;
    public string type;
    public GameEvent foodEvent;
}
