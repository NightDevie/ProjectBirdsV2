using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingState : State
{
    public override void OnStateEnter()
    {
        Debug.Log("Entering FlyingState");
        gM.obstacleManager.ObstaclePoolSpawn();
        gM.bird.EnableFlap();
        gM.bird.UnFreezeBirdY();
    }

    public override void Update()
    {
        gM.obstacleManager.ObstacleReposition();
        gM.bird.RotateBird();
    }

    public override void OnStateExit()
    {
        Debug.Log("Exiting FlyingState");
        gM.bird.DisableFlap();
    }
}
