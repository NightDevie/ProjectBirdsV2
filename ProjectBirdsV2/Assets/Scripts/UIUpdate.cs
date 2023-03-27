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
        InputSystem.pollingFrequency = Screen.currentResolution.refreshRate;

        Application.targetFrameRate = 60;
        QualitySettings.vSyncCount = 0;
    }

    //void OnGUI()
    void FixedUpdate()
    {
        InputSystem.Update();
    }
}
