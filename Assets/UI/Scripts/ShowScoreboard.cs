using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowScoreboard : MonoBehaviour
{
    public GameObject scoreboardPanel;
    public float delay = 15f;            // När panelen ska visas
    public float autoLoadDelay = 10f;    // När nästa scen ska laddas efter panelen visas
    public string nextSceneName = "2.P2";

    void Start()
    {
        scoreboardPanel.SetActive(false);
        Invoke("ShowPanel", delay);
    }

    void ShowPanel()
    {
        scoreboardPanel.SetActive(true);

        // Starta timer för att automatiskt ladda nästa scen efter 10 sek
        Invoke("LoadNextScene", autoLoadDelay);
    }

    void LoadNextScene()
    {
        if (!string.IsNullOrEmpty(nextSceneName))
        {
            SceneManager.LoadScene(nextSceneName);
        }
        else
        {
            Debug.LogWarning("Next scene name is not set!");
        }
    }
}
