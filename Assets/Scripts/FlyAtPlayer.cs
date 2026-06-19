using System.Net.Sockets;
using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] Transform player;
    Vector3 playerPosition;

    void Awake()
    {
        gameObject.SetActive(false);
    }

    void Start()
    {
        playerPosition = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        moveToPlayer();   
        destroyWhenReached();
    }
    void moveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, 1f * Time.deltaTime * speed);
    }
    //void destroyWhenReached()
    //{
    //    if (gameObject.transform.position == playerPosition)
    //    {

    //         Destroy(gameObject);
    //    }

    //}
    void destroyWhenReached()
    {
        if (Vector3.Distance(transform.position, playerPosition) < 0.1f)
        {
            gameObject.SetActive(false);
        }
    }
}
