using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    [SerializeField] private GameObject obstacle;
    [SerializeField] private float spawnRange;
    [SerializeField] private float timeToSpawn;
    void Start()
    {
        StartCoroutine(nameof(SpawnNewObstacle));
    }

    IEnumerator SpawnNewObstacle()
    {
        float y = Random.Range(0, spawnRange);
        Vector2 spawnPosition = new Vector2(transform.position.x, transform.position.y + y);

        Instantiate(obstacle, spawnPosition, Quaternion.identity);

        yield return new WaitForSeconds(timeToSpawn);
        StartCoroutine(nameof(SpawnNewObstacle));
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawLine(transform.position, new Vector2(transform.position.x, transform.position.y + spawnRange));
    }
}
