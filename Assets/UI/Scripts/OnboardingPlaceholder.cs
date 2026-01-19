using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class OnboardingPlaceholder : MonoBehaviour
{
    public float duration = 15f; // 15 sekunder
    public string nextSceneName = "Practice1Scene";

    void Start()
    {
        StartCoroutine(WaitAndLoad());
    }

    IEnumerator WaitAndLoad()
    {
        yield return new WaitForSeconds(duration);
        SceneManager.LoadScene(nextSceneName);
    }
}
