using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class UIUpdate : MonoBehaviour
{
    void OnGUI()
    {
        InputSystem.Update();
    }
}
