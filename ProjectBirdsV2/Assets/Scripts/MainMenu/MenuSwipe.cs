using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuSwipe : MonoBehaviour
{
    [SerializeField]
    private Scrollbar scrollbar;

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
    private float lerpDuration = 0.1f;
    private float[] menuScreens;
    private int currentMenuScreen;

    [SerializeField]
    private GameObject[] buttons;
    [SerializeField]
    private Sprite[] buttonSprites;
    [SerializeField]
    private Sprite[] buttonSpritesSelected;

    private void Start()
    {
        menuScreens = new float[transform.childCount];

        menuScreens[0] = 0f;
        menuScreens[1] = 0.25f;
        menuScreens[2] = 0.5f;
        menuScreens[3] = 0.75f;
        menuScreens[4] = 1f;

        currentMenuScreen = 2;

        for (int i = 0; i <= 4; i++)
        {
            int x = i;
            buttons[x].GetComponent<Button>().onClick.AddListener(() => OnButtonClick(x));
        }
    }

    private void OnButtonClick(int n)
    {
        buttons[currentMenuScreen].GetComponent<Image>().sprite = buttonSprites[currentMenuScreen];
        currentMenuScreen = n;
        buttons[currentMenuScreen].GetComponent<Image>().sprite = buttonSpritesSelected[currentMenuScreen];

        StartCoroutine(LerpScreen(menuScreens[currentMenuScreen], lerpDuration));
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
                    if(currentMenuScreen != i)
                    {
                        buttons[currentMenuScreen].GetComponent<Image>().sprite = buttonSprites[currentMenuScreen];
                        currentMenuScreen = i;
                        buttons[currentMenuScreen].GetComponent<Image>().sprite = buttonSpritesSelected[currentMenuScreen];
                    }

                    StartCoroutine(LerpScreen(menuScreens[i], lerpDuration));
                    break;
                }
            }
        }
    }

    private void SwipeDirection(Vector2 direction)
    {
        if (Vector2.Dot(Vector2.left, direction) > directionThreshold && currentMenuScreen != 4)
        {
            buttons[currentMenuScreen].GetComponent<Image>().sprite = buttonSprites[currentMenuScreen];
            currentMenuScreen++;
            buttons[currentMenuScreen].GetComponent<Image>().sprite = buttonSpritesSelected[currentMenuScreen];

            StartCoroutine(LerpScreen(menuScreens[currentMenuScreen], lerpDuration));
        }
        else if (Vector2.Dot(Vector2.right, direction) > directionThreshold && currentMenuScreen != 0)
        {
            buttons[currentMenuScreen].GetComponent<Image>().sprite = buttonSprites[currentMenuScreen];
            currentMenuScreen--;
            buttons[currentMenuScreen].GetComponent<Image>().sprite = buttonSpritesSelected[currentMenuScreen];

            StartCoroutine(LerpScreen(menuScreens[currentMenuScreen], lerpDuration));
        }
        else
        {
            StartCoroutine(LerpScreen(menuScreens[currentMenuScreen], lerpDuration));
        }
    }
    private IEnumerator LerpScreen(float endPosition, float duration)
    {
        float time = 0;

        while (time < duration)
        {
            scrollbar.value = Mathf.Lerp(scrollbar.value, endPosition, time / duration);
            time += Time.deltaTime;
            yield return null;
        }

        scrollbar.value = endPosition;
    }

    //private IEnumerator LerpScreen2(float time, float endPosition)
    //{
    //    float endPos = endPosition;

    //    float start = Time.time;

    //    while (Time.time < start + time)
    //    {
    //        scrollbar.value = Mathf.Lerp(scrollbar.value, endPos, 0.1f);
    //        yield return null;
    //    }

    //    scrollbar.value = endPos;
    //}
}
