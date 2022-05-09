using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using DG.Tweening;

public class Bird : MonoBehaviour
{
    public int score;

    private Rigidbody2D rb2d;
    private PlayerControls touchControls;
    
    [SerializeField]
    private float flapForce;

    private bool gameOver = false;

    private bool up = true;

    


    private void Awake()
    {
        touchControls = new PlayerControls();
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        score = 0;
    }

    public void UnFreezeBirdY()
    {
        rb2d.constraints = RigidbodyConstraints2D.FreezePositionX;
        rb2d.velocity = Vector2.up * flapForce;
    }

    public void RotateBird()
    {
        if (rb2d.velocity.y > -1f)
        {
            rb2d.transform.DOLocalRotate(new Vector3(0f, 0f, 30f), 0.1f).SetEase(Ease.OutQuad);
            up = false;
        }
        else if(rb2d.velocity.y < -1f && up == false)
        {
            rb2d.transform.DOLocalRotate(new Vector3(0f, 0f, -90f), 0.6f).SetEase(Ease.InQuad);
            up = true;
        }
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
        GameManager.gM.gameUIManager.SetScore(score);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.gM.SwitchState(new GameOverState());

        if(gameOver == false && collision.gameObject.tag == "Obstacle")
        {
            foreach (BoxCollider2D bc2d in collision.gameObject.GetComponentsInChildren<BoxCollider2D>())
            {
                bc2d.enabled = false;
            }
        }

        gameOver = true;
    }
}
