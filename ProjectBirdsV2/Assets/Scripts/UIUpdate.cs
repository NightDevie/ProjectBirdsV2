using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[DefaultExecutionOrder(-2)]
public class UIUpdate : MonoBehaviour
{
    private void Start()
    {
        //Time.fixedDeltaTime = 1 / 60;
        //Application.targetFrameRate = Screen.currentResolution.refreshRate;
        //InputSystem.pollingFrequency = 120;

        //Application.targetFrameRate = 57;
        //QualitySettings.vSyncCount = 0;
    }

    //void OnGUI()
    void FixedUpdate()
    {
        InputSystem.Update();
    }
}
