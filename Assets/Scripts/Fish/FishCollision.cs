using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Obstacle":
                collision.GetComponent<Obstacle>().Stop();
                collision.transform.SetParent(transform);
                break;
        }
        
    }
}
