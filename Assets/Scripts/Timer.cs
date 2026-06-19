using UnityEngine;

public class Timer : MonoBehaviour
{
    float elapsedTime = 0f;

    void Update()
    {
        elapsedTime += Time.deltaTime;
    }

    public float GetTime()
    {
        return elapsedTime;
    }
}