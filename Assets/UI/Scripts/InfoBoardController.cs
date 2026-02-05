using UnityEngine;

public class InfoBoardController : MonoBehaviour
{
    public GameObject info; // The info board
    public GameObject Scoardboard; // The panel that has the button

    public void ShowInfoBoard()
    {
        if (info != null)
            info.SetActive(true);
        if (Scoardboard != null)
            Scoardboard.SetActive(false); // hide the buttons
    }

    // Optional: hide info board and show buttons again
    public void HideInfoBoard()
    {
        if (info != null)
            info.SetActive(false);
        if (Scoardboard != null)
            Scoardboard.SetActive(true);
    }
}
