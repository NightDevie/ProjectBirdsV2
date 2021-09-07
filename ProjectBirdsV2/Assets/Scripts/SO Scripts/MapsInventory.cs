using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Maps Inventory", menuName = "Maps Inventory")]
public class MapsInventory : ScriptableObject
{
    public List<MapData> items = new List<MapData>();
}
