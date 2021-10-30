using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishCollision : MonoBehaviour
{
    FishMove fishMove;
    private void Start()
    {
        fishMove = GetComponent<FishMove>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Obstacle":
                fishMove.DecreaseSpeed();
                collision.GetComponent<Obstacle>().Stop();
                collision.transform.SetParent(transform);
                break;
        }
        
    }
}
