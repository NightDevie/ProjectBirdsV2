using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuSwipe : MonoBehaviour
{
    public float swipeRange;
    public float tapRange;
    public Scrollbar scrollbar;

    [SerializeField]
    private InputManager inputManager;

    [SerializeField]
    private float minimumDistance = 0.2f;
    [SerializeField]
    private float maximumTime = 1f;
    [SerializeField]
    private float directionThreshold = 0.9f;

    private Vector2 startPosition;
    private float startTime;
    private Vector2 endPosition;
    private float endTime;

    [SerializeField]
    private float lerpTime = 0.1f;
    private float[] menuScreens;
    private int currentMenuScreen;


    private void Start()
    {
        menuScreens = new float[transform.childCount];

        menuScreens[0] = 0f;
        menuScreens[1] = 0.25f;
        menuScreens[2] = 0.5f;
        menuScreens[3] = 0.75f;
        menuScreens[4] = 1f;

        currentMenuScreen = 2;
    }

    private void OnEnable()
    {
        inputManager.OnStartTouch += SwipeStart;
        inputManager.OnEndTouch += SwipeEnd;
    }

    private void OnDisable()
    {
        inputManager.OnStartTouch -= SwipeStart;
        inputManager.OnEndTouch -= SwipeEnd;
    }

    private void SwipeStart(Vector2 position, float time)
    {
        startPosition = position;
        startTime = time;
    }

    private void SwipeEnd(Vector2 position, float time)
    {
        endPosition = position;
        endTime = time;
        DetectSwipe();
    }

    private void DetectSwipe()
    {
        if (Vector3.Distance(startPosition, endPosition) >= minimumDistance && (endTime - startTime) <= maximumTime)
        {
            Vector3 direction = endPosition - startPosition;
            Vector2 direction2D = new Vector2(direction.x, direction.y).normalized;
            SwipeDirection(direction2D);
        }
        else
        {
            float distance = 1f / (menuScreens.Length - 1f);
            float scrollPos = scrollbar.value;

            for (int i = 0; i < menuScreens.Length; i++)
            {
                if (scrollPos < menuScreens[i] + (distance / 2) && scrollPos > menuScreens[i] - (distance / 2))
                {
                    StartCoroutine(LerpScreen(lerpTime, menuScreens[i]));
                }
            }
        }
    }

    private void SwipeDirection(Vector2 direction)
    {
        if (Vector2.Dot(Vector2.left, direction) > directionThreshold && currentMenuScreen != 4)
        {
            currentMenuScreen++;
            StartCoroutine(LerpScreen(lerpTime, menuScreens[currentMenuScreen]));
        }
        else if (Vector2.Dot(Vector2.right, direction) > directionThreshold && currentMenuScreen != 0)
        {
            currentMenuScreen--;
            StartCoroutine(LerpScreen(lerpTime, menuScreens[currentMenuScreen]));
        }
    }

    private IEnumerator LerpScreen(float time, float endPosition)
    {
        float endPos = endPosition;

        float start = Time.time;

        while (Time.time < start + time)
        {
            scrollbar.value = Mathf.Lerp(scrollbar.value, endPos, 0.1f);
            yield return null;
        }

        scrollbar.value = endPos;
    }
}
