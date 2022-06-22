using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSize : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float dynamicSize = 162 * Screen.height / Screen.width * 0.5f;

        Camera.main.orthographicSize = dynamicSize / 16;
    }
}
