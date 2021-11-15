using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[DefaultExecutionOrder(-2)]
public class UIUpdate : MonoBehaviour
{
    void OnGUI()
    {
        InputSystem.Update();
    }
}
