using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishCollision : MonoBehaviour
{
    FishMove fishMove;
    FishSoundFX fishSoundFX;
    private void Start()
    {
        fishSoundFX = FishSoundFX.fishSoundFx;
        fishMove = GetComponent<FishMove>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Obstacle":
                fishSoundFX.PlayObstacleFx(1);
                fishMove.DecreaseSpeed();
                collision.GetComponent<Obstacle>().Stop();
                collision.transform.SetParent(transform);
                break;
        }
        
    }
}
