using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollRectSize : MonoBehaviour
{
    [SerializeField]
    private RectTransform canvasRectT;

    void Start()
    {
        RectTransform rectT = gameObject.GetComponent<RectTransform>();

        rectT.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, canvasRectT.rect.width);
        rectT.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, canvasRectT.rect.height);
        rectT.SetPositionAndRotation(new Vector3(), new Quaternion());

        //float a = rectT.rect.height;
        //float b = (rectT.rect.height - a) / 2;
        //float c = rectT.anchoredPosition.y + b;
        //Debug.Log(rectT.rect.position.y);
    }
}
