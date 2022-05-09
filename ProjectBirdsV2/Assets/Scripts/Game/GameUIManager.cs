using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameUIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject gameOverMenu;

    [SerializeField]
    private GameObject scoreObject;

    private TextMeshProUGUI score;

    private void Start()
    {
        score = scoreObject.GetComponent<TextMeshProUGUI>();
    }

    public void EnableDisableGameOverMenu(bool value)
    {
        gameOverMenu.SetActive(value);
    }

    public void SetScore(int sc)
    {
        score.SetText(sc.ToString());
    }
}
