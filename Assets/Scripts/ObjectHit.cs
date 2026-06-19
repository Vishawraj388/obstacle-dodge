using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    public Material hitMaterial;
    bool hasBeenHit = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && !hasBeenHit)
        {
            hasBeenHit = true;

            GetComponent<MeshRenderer>().material = hitMaterial;

            Scorer scorer = collision.gameObject.GetComponent<Scorer>();

            if (scorer != null)
            {
                scorer.IncreaseScore();
            }
        }
    }
}