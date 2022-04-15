using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    public void LoadGameScene()
    {
        StartCoroutine(LoadGameSceneAsync());
    }

    IEnumerator LoadGameSceneAsync()
    {
        transition.SetTrigger("Start");

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("GameScene");
        while(!asyncLoad.isDone)
        {
            yield return new WaitForSeconds(transitionTime);
        }
    }
}
