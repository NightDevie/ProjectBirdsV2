using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;
using UnityEngine.InputSystem.Utilities;

public class StartState : State
{

    public override void OnStateEnter()
    {
        Debug.Log("Entering StartState");

        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = Screen.currentResolution.refreshRate;

        InputSystem.onAnyButtonPress.CallOnce(ctrl => gM.SwitchState(new FlyingState()));
    }

    public override void Update()
    {
        
    }

    public override void OnStateExit()
    {
        Debug.Log("Exiting StartState");
    }
}
