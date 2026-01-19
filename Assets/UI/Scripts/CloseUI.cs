using UnityEngine;

public class CloseUI : MonoBehaviour
{
    public GameObject scoreboard;  // hela din scoreboard Canvas/Panel

    public void CloseScoreboard()
    {
        scoreboard.SetActive(false);
    }
}
