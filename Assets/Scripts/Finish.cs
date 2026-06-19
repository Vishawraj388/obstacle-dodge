using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] FinishUI finishUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Scorer scorer = other.GetComponent<Scorer>();
            Timer timer = other.GetComponent<Timer>();

            if (scorer != null && timer != null)
            {
                finishUI.ShowFinishScreen(
                    timer.GetTime(),
                    scorer.GetDamageTaken()
                );
            }
        }
    }
}