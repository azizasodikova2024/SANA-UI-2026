using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueButton : MonoBehaviour
{
    public string nextScene;

    public void OnContinue()
    {
        SceneManager.LoadScene(nextScene);
    }
}
