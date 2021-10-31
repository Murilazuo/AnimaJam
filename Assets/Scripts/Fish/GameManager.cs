using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static float startTime;
    public static float timeScore = 0;
    public static int endId;

    public static GameManager gameManager;
    private void Awake()
    {
        gameManager = this;
        RestartTime();
    }
    public static void RestartTime()
    {
        startTime = Time.time;
    }

    public void GameOver(int newEndId)
    {
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
