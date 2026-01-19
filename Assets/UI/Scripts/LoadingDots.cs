using UnityEngine;

public class LoadingDots : MonoBehaviour
{
    public Transform[] dots;
    public float speed = 2f;

    void Update()
    {
        for (int i = 0; i < dots.Length; i++)
        {
            float scale = 0.5f + 0.5f * Mathf.Sin(Time.time * speed + i);
            dots[i].localScale = new Vector3(scale, scale, 1);
        }
    }
}
