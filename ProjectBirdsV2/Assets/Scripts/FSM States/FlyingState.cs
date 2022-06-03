using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingState : State
{
    public override void OnStateEnter()
    {
        Debug.Log("Entering FlyingState");
        gM.obstacleManager.ObstaclePoolSpawn();
        gM.bird.animator.SetBool("GameStarted", true);
        gM.bird.EnableFlap();
        gM.bird.UnFreezeBirdY();
    }

    public override void Update()
    {
        gM.obstacleManager.ObstacleReposition();
        gM.bird.RotateBird();
        gM.bird.animator.SetFloat("BirdSpeed", gM.bird.rb2d.velocity.y);
    }

    public override void OnStateExit()
    {
        Debug.Log("Exiting FlyingState");
        gM.bird.DisableFlap();
    }
}
