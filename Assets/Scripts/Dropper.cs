using Unity.VisualScripting;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField]float timeToWait = 2f;
    bool hasPrinted = true;
    MeshRenderer myMeshrenderer;
    Rigidbody myRigidbody;
    void Start()
    {
        myMeshrenderer = GetComponent<MeshRenderer>();
        myMeshrenderer.enabled = false;
        myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.useGravity = false; 
    }
    void Update()
    {
        if (Time.time> timeToWait && hasPrinted)
        {
            myMeshrenderer.enabled=true;
            myRigidbody.useGravity=true;
            Debug.Log("Look up Below!");
            hasPrinted = false;
            
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject != gameObject)
        {
            gameObject.SetActive(false);
        }
    }
}
