using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameUIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject gameOverMenu;

    [SerializeField]
    private TMP_Text score;

    public void EnableDisableGameOverMenu(bool value)
    {
        gameOverMenu.SetActive(value);
    }

    public void SetScore(int sc)
    {
        score.text = sc.ToString();
    }
}
