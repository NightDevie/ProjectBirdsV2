using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BirdController : MonoBehaviour, IPointerDownHandler, IMoveHandler
{
    private Rigidbody2D rb2d;
    public float flapForce;

    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        CheckTouch();
    }

    private void CheckTouch()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                Flap();
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            Flap();
        }
    }

    private void Flap()
    {
        //rb2d.AddForce(Vector2.up * flapForce);
        rb2d.velocity = Vector2.up * flapForce;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        rb2d.AddForce(Vector2.up * flapForce);
    }

    public void OnMove(AxisEventData eventData)
    {

    }
}
