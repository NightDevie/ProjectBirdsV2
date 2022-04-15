using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class StartState : State
{
    bool touchReady = false;

    public override void OnStateEnter()
    {
        Debug.Log("Entering StartState");

        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = Screen.currentResolution.refreshRate;

        touchReady = true;
    }

    public override void Update()
    {
        if (touchReady == true)
        {
            TouchStart();
        }

    }

    private void TouchStart()
    {
        if (Input.touchCount > 0 || Mouse.current.leftButton.isPressed)
        {
            gM.SwitchState(new FlyingState());
        }
    }

    public override void OnStateExit()
    {
        Debug.Log("Exiting StartState");
    }
}
