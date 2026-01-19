using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class UIManager : MonoBehaviour
{
    [Header("Panels")]
    public GameObject splashPanel;
    public GameObject loadingPanel;
    public GameObject homePanel;

    [Header("Settings")]
    public float splashDuration = 2.5f; // hur länge splashen visas

    void Start()
    {
        // Visa Splash och starta laddning av Home
        splashPanel.SetActive(true);
        loadingPanel.SetActive(true); // aktiveras samtidigt
        homePanel.SetActive(false);

        StartCoroutine(LoadHomeAsync());
    }

    IEnumerator LoadHomeAsync()
    {
        // Starta async-laddning av nästa scen (om du har HomeScene)
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("HomeScene");
        asyncLoad.allowSceneActivation = false;

        // Vänta tills Splash-tiden har gått
        yield return new WaitForSeconds(splashDuration);

        // Dölj Splash när den är klar
        splashPanel.SetActive(false);

        // Vänta tills scenen är redo
        while (!asyncLoad.isDone)
        {
            // När progress når 0.9 är scenen färdig att aktiveras
            if (asyncLoad.progress >= 0.9f)
            {
                asyncLoad.allowSceneActivation = true;
            }
            yield return null;
        }
    }

    // Du behåller din gamla metod – bra för UI-växling i HomeScene
    public void ShowPanel(GameObject panelToShow)
    {
        splashPanel.SetActive(false);
        loadingPanel.SetActive(false);
        homePanel.SetActive(false);

        if (panelToShow != null)
            panelToShow.SetActive(true);
    }
}
