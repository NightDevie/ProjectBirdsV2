using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New MenuButtonsSprites", menuName = "MenuButtonsSprites")]
public class MenuButtonsSprites : ScriptableObject
{
    public GameObject[] buttons;
    public Sprite[] buttonSprites;
    public Sprite[] buttonSpritesSelected;
}
