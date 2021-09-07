using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Birds Inventory", menuName = "Birds Inventory")]
public class BirdsInventory : ScriptableObject
{
    //public Dictionary<int, BirdData> items = new Dictionary<int, BirdData>();
    public List<BirdData> items = new List<BirdData>();
}
