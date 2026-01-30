using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;

public class SplashLoader : MonoBehaviour
{
    public TextMeshProUGUI loadingText;
    public string nextSceneName = "MainScene";

    private int dotCount = 0;
    private const int maxDots = 3;

    void Start()
    {
        StartCoroutine(AnimateDots());
        StartCoroutine(LoadNextScene());
    }

    IEnumerator AnimateDots()
    {
        while (true)
        {
            dotCount = (dotCount + 1) % (maxDots + 1);
            loadingText.text = new string('●', dotCount);
            yield return new WaitForSeconds(0.5f);
        }
    }

    IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(2f);

        AsyncOperation loadOperation = SceneManager.LoadSceneAsync(nextSceneName);
        loadOperation.allowSceneActivation = false;

        while (loadOperation.progress < 0.9f)
        {
            yield return null;
        }

        yield return new WaitForSeconds(0.5f);
        loadOperation.allowSceneActivation = true;
    }
}

