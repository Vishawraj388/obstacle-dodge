using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float movespeed=8f;
    void Start()
    {
        PrintInstruction();   
    }


    void Update()
    {
        MovePlayer();
    }

    void PrintInstruction()
    {
        Debug.Log("Welcome To The Game!");
        Debug.Log("Obstacle Dodge");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * movespeed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * movespeed;
        transform.Translate(xValue, yValue, zValue);
    }
}
