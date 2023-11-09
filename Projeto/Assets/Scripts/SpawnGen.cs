using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstaclePrefabs; // Prefab dos obstaculos
    public Transform spawnPoint; // spawnpoint obstaculo
    public float minSpawnTime = 1f; // tempo mínimo entre a geração de obstaculo
    public float maxSpawnTime = 3f; // tempo máximo entre a geração de obstaculo

    private float nextSpawnTime;

    private void Start()
    {
        nextSpawnTime = UnityEngine.Random.Range(minSpawnTime, maxSpawnTime);
    }

    private void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnObstacle();
            nextSpawnTime = Time.time + UnityEngine.Random.Range(minSpawnTime, maxSpawnTime);
        }
    }

    private void SpawnObstacle()
    {
        if (obstaclePrefabs.Length == 0)
        {
            UnityEngine.Debug.LogWarning("Nenhum prefab de obstáculo foi atribuído.");
            return;
        }

        int randomIndex = UnityEngine.Random.Range(0, obstaclePrefabs.Length);
        GameObject obstacle = Instantiate(obstaclePrefabs[randomIndex], spawnPoint.position, Quaternion.identity);
    }
}
