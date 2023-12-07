using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Recipes", menuName = "ScriptableObjects/Recipes", order = 1)]
public class Recipes : ScriptableObject
{
    public Items item1;
    public bool itema1IsConsumed;

    public Items item2;
    public bool item2IsConsumed;

    public Items itemToProduce;
}
