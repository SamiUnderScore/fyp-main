using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SplashScene : MonoBehaviour
{
    public Image fillBar;
    [SerializeField]
    private int index;
    [SerializeField]
    private float totalTime;

    private void Start()
    {
        StartCoroutine(FillBar(totalTime));
    }

    public IEnumerator FillBar(float totalTime)
    {
        float elapsedTime = 0;
        while(elapsedTime < totalTime)
        {
            elapsedTime += Time.deltaTime;
            fillBar.fillAmount = elapsedTime / totalTime;
            yield return null;
        }
        yield return StartCoroutine(LoadScene(1));
    }

    private IEnumerator LoadScene(int index)
    {
        SceneManager.LoadScene(index);
        yield return null;
    }
}

