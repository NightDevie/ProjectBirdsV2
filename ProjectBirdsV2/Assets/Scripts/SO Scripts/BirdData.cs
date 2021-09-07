using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Bird", menuName = "Bird")]
public class BirdData : ScriptableObject
{
    public bool owned = false;

    public new string name;
    public float price;

    public Sprite[] sprites;
    public Animation flapAnim;
}
