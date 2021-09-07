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
    }

    public override void Update()
    {
        gM.obstacleManager.ObstacleReposition();
        //gM.bird.RotateBird();
        //gS.obstacleMover.MoveObstacles();
    }

    public override void OnStateExit()
    {
        Debug.Log("Exiting FlyingState");
        gM.bird.DisableFlap();
    }
}
