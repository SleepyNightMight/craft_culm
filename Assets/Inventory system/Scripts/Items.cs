using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "ScriptableObjects/Items", order = 1)]
public class Items : ScriptableObject
{
    public Sprite itemIcon;
    public string itemName;

    public List<Recipes> isUsedWith;

}
