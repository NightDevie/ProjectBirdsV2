using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Bird : MonoBehaviour
{
    public int score;

    public int flapRotation;

    private Rigidbody2D rb2d;
    private PlayerControls touchControls;

    [SerializeField] private float flapForce;

    //------------------------------------------------- test vars
    [SerializeField] private int upRotation;
    [SerializeField] private int downRotation; 
    [SerializeField] private float rotationSpeed;

    private Quaternion upRot;
    private Quaternion downRot;

    //private Vector3 eulerAngleVelocity;
    private float lastVelocity = 0;

    private void Awake()
    {
        touchControls = new PlayerControls();
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        score = 0;

        //eulerAngleVelocity = new Vector3(0, 0, flapRotation);
        upRot = Quaternion.Euler(0, 0, upRotation);
        downRot = Quaternion.Euler(0, 0, downRotation);
    }
    /*
    private void OnGUI()
    {
        InputSystem.Update();
    }*/

    public void RotateBird()
    {
        //rb2d.transform.eulerAngles = new Vector3(0, 0, rb2d.transform.rotation.z * rb2d.velocity.y * Time.deltaTime);
        
        if(rb2d.velocity.y > lastVelocity)
        {
            //Quaternion deltaRotation = Quaternion.Euler(eulerAngleVelocity * Time.deltaTime);
            //rb2d.MoveRotation(rb2d.rotation + 5 * Time.fixedDeltaTime);
            rb2d.transform.rotation = Quaternion.Lerp(rb2d.transform.rotation, downRot, rotationSpeed * Time.deltaTime);
        }
        else
        {
            rb2d.transform.rotation = Quaternion.Lerp(rb2d.transform.rotation, downRot, rotationSpeed * Time.deltaTime);
        }
        lastVelocity = rb2d.velocity.y;
    }

    private void Update()
    {
        //rb2d.rotation = Quaternion.Lerp(rb2d.rotation, downRot, rotationSpeed * Time.deltaTime);
        //rb2d.MoveRotation(Mathf.LerpAngle(rb2d.rotation, downRotation, rotationSpeed * Time.deltaTime));
    }

    public void EnableFlap()
    {
        touchControls.Bird.Flap.Enable();
        touchControls.Bird.Flap.started += ctx => Flap(ctx);
    }

    public void DisableFlap()
    {
        touchControls.Bird.Flap.started -= ctx => Flap(ctx);
        touchControls.Bird.Flap.Disable();
    }

    private void Flap(InputAction.CallbackContext context)
    {
        //rb2d.AddForce(Vector2.up * flapForce);
        rb2d.velocity = Vector2.up * flapForce;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        score++;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("bird died");
        GameManager.gM.SwitchState(new GameOverState());
    }
}
