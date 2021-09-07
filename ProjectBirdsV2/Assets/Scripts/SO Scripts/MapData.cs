using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Map", menuName = "Map")]
public class MapData : ScriptableObject
{
    public new string name;

    public Sprite backgroundArtwork;
    public Sprite treeArtwork;
    public Sprite obstacleArtwork;
}
