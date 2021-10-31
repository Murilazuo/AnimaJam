using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FishHook : MonoBehaviour
{
    [SerializeField] private Vector2 move;
    [SerializeField] private float timeToGoBack = 1,timeToCatchFish = 1, timeToNextScene = 1;
    [SerializeField] private string nextSceneName;
    Rigidbody2D rig;
    SoundFish soundFish;
    void Start()
    {
        transform.position = new Vector2(FishMove.fishMove.transform.position.x, 8);
        rig = GetComponent<Rigidbody2D>();
        Invoke(nameof(Move), timeToCatchFish);
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            rig.velocity = Vector2.zero;
            collision.transform.SetParent(transform);
            collision.GetComponent<Rigidbody2D>().simulated = false;
            collision.GetComponent<SoundFish>().PlaySound(3);
            Invoke(nameof(GoBack), timeToGoBack);
        }
    }
    void Move()
    {
        rig.velocity = move;
    }
    void GoBack()
    {
        rig.velocity = -move;
        Invoke(nameof(GoToNextScene), timeToNextScene);
    }
    void GoToNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
