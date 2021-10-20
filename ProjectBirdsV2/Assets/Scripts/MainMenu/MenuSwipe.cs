using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class MenuSwipe : MonoBehaviour
{
    public GameObject scrollbar;
    float scroll_pos = 5;
    float[] pos;

    private TouchControls touchControls;

    private void Awake()
    {
        touchControls = new TouchControls();
        touchControls.Menu.Hold.Enable();
    }

    private void Update()
    {
        
    }

    //private void Update()
    //{
    //    pos = new float[transform.childCount];
    //    float distance = 1f / (pos.Length - 1f);
    //    for (int i = 0; i < pos.Length; i++)
    //    {
    //        pos[i] = distance * i;
    //    }

    ////    var touchscreen = InputSystem.AddDevice<Touchscreen>();
    ////    Touchscreen.current.IsPressed() | Mouse.current.leftButton.isPressed
    //    if (touchControls.Menu.Hold.phase == InputActionPhase.Performed)
    //    {
    //        scroll_pos = scrollbar.GetComponent<Scrollbar>().value;
    //    }
    //    else
    //    {
    //        for (int i = 0; i < pos.Length; i++)
    //        {
    //            if (scroll_pos < pos[i] + (distance / 2) && scroll_pos > pos[i] - (distance / 2))
    //            {
    //                scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, pos[i], 0.1f);
    //            }
    //        }
    //    }
    //}
}
