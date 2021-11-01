using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static float startTime;
    public static float timeScore = 0;
    public static int endId;

    [SerializeField] private Sprite[] sprites;
    public static GameManager gameManager;
    private void Awake()
    {
        gameManager = this;
        SpawnObstacle.stop = false;
        RestartTime();
    }
    public static void RestartTime()
    {
        startTime = Time.time;
    }

    public void GameOver(int newEndId)
    {
        var playerSpr = GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>();
        if(playerSpr.sprite == sprites[0])
        {
            playerSpr.sprite = sprites[1];
        }else
        {
            playerSpr.sprite = sprites[2];
        }
        SpawnObstacle.stop = true;
        endId = newEndId;
        timeScore = Time.time - startTime;
        Invoke(nameof(GameOverScene),5);
    }

    private void GameOverScene()
    {
        SceneManager.LoadScene("GameOver");
    }

}
