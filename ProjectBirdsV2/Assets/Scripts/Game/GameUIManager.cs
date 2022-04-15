using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject gameOverMenu;

    public void EnableDisableGameOverMenu(bool value)
    {
        gameOverMenu.SetActive(value);
    }
}
