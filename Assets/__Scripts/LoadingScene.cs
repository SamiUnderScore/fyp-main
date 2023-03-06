using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScene : MonoBehaviour
{
    public Image fillBar;
    public int sceneNo = 0;
    public float delayInLoad = 0;



    private void Start()
    {
        LoadScene(sceneNo);
    }

    public void LoadScene(int buildSceneNumber)
    {
        StartCoroutine(LoadSceneAsync(buildSceneNumber));
    }

    private IEnumerator LoadSceneAsync(int buildSceneNumber)
    {
        yield return new WaitForSeconds(delayInLoad);
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(buildSceneNumber);

        while (!asyncLoad.isDone)
        {
            float progress = Mathf.Clamp01(asyncLoad.progress / 0.9f);
            fillBar.fillAmount = progress;
            yield return null;
        }
    }
}