using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverState : State
{
    private int score;
    public override void OnStateEnter()
    {
        Debug.Log("Entering GameOverState");
        score = gM.bird.score;
        SetScore();
        SetSilver();
    }

    private bool CalculateEggDrop(int score) // if player don't drop for 10000 score added, they should maybe drop.
    {
        int value = Random.Range(1, 10000);
            return (value <= score);
    }

    private bool CalculateGoldDrop(int score) // if player don't drop for 2000 score added, they should maybe drop.
    {
        int value = Random.Range(1, 2000);
        return (value <= score);
    }

    private void DropsRewards()
    {
        if (CalculateEggDrop(score))
        {

        }

        if (CalculateGoldDrop(score))
        {
            gM.profileData.Gold = 1;
        }
    }

    private void SetScore()
    {
        gM.profileData.BestScore = score;
        gM.profileData.scoreHistory.Add(score);
    }

    private void SetSilver()
    {
        gM.profileData.Silver = score;
    }

    public override void OnStateExit()
    {
        Debug.Log("Exiting GameOverState");
    }
}
