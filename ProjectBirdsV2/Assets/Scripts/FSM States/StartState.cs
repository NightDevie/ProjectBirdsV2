using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartState : State
{
    public override void OnStateEnter()
    {
        Debug.Log("Entering StartState");
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = Screen.currentResolution.refreshRate;
        gM.SwitchState(new FlyingState());
    }

    public override void OnStateExit()
    {
        Debug.Log("Exiting StartState");
    }
}
