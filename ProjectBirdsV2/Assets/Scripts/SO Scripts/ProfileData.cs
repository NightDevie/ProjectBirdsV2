using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Profile Data", menuName = "ProfileData")]
public class ProfileData : ScriptableObject
{
    public string playerName;
    public int playerAge;
    public int playerBirthdayDay;
    public int playerBirthdayMonth;
    public List<int> scoreHistory = new List<int>();

    [SerializeField]
    private int bestScore;
    [SerializeField]
    private int gold;
    [SerializeField]
    private int silver;

    public int BestScore
    {
        get { return bestScore; }
        set { if (value > bestScore) { bestScore = value; } }
    }

    public int Gold
    {
        get { return gold; }
        set { gold += value; }
    }

    public int Silver
    {
        get { return silver; }
        set
        { Debug.Log(value); silver += value;
            while (silver >= 1000)
            { 
                { gold += 1; silver -= 1000; }
            }
        }
    }
}
