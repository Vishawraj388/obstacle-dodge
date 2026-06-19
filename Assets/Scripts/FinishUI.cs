using TMPro;
using UnityEngine;

public class FinishUI : MonoBehaviour
{
    [SerializeField] GameObject finishPanel;
    [SerializeField] TMP_Text timeText;
    [SerializeField] TMP_Text scoreText;

    public void ShowFinishScreen(float time, int damage)
    {
        finishPanel.SetActive(true);

        timeText.text = "Time: " + time.ToString("F1") + "s";
        scoreText.text = "Damage Taken: " + damage;

        Time.timeScale = 0f;
    }
}