using UnityEngine;

public class Scorer : MonoBehaviour
{
    int damageTaken = 0;

    public void IncreaseScore()
    {
        damageTaken++;
        Debug.Log("Damage Taken: " + damageTaken);
    }

    public int GetDamageTaken()
    {
        return damageTaken;
    }
}