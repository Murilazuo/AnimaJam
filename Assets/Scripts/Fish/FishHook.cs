using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FishHook : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    [SerializeField] private float timeToGoBack = 1;
    Rigidbody2D rig;
    SoundFish soundFish;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = Vector2.left * speed;
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            rig.velocity = Vector2.zero;
            collision.GetComponent<FishMove>().speed = 0;
            collision.GetComponent<Rigidbody2D>().simulated = false;
            //collision.GetComponent<SoundFish>().PlaySound(3);
            collision.transform.SetParent(transform);
            Invoke(nameof(GoBack), timeToGoBack);
        }
    }
    
    void GoBack()
    {
        rig.velocity = Vector2.up * speed;
        GameManager.gameManager.GameOver(2);
    }
    
}
