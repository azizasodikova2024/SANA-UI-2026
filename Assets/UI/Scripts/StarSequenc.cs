using UnityEngine;

public class StarSequence : MonoBehaviour
{
    public Animator starLeft;
    public Animator starMiddle;

    void Start()
    {
        starLeft.Play("StarPop");
        Invoke(nameof(PlayMiddle), 0.4f);
    }

    void PlayMiddle()
    {
        starMiddle.Play("StarPop_Middle");
    }
}
