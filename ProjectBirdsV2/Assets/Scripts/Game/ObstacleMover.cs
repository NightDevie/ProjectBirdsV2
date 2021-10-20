using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMover : MonoBehaviour
{
    [SerializeField] private float velocity;
    private Rigidbody2D rb2d;

    private void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (GameManager.gM.stateName == "FlyingState")
        {
            rb2d.transform.position += Vector3.left * velocity * Time.deltaTime;
            //transform.position += Vector3.left * velocity * Time.deltaTime;
        }
    }
}
