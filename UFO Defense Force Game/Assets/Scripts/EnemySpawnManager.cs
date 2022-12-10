using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    [SerializeField]
    private float spawnRangeX = 14f, spawnPosZ = 40f;
    private float startDelay = 2f, spawnInterval = 3f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval);
    }

    void SpawnRandomEnemy()
    {
        // Generate random position to spawn at
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        // pick random enemy ship
        int enemyIndex = Random.Range(0, enemyPrefabs.Length);
        // spawn enemy
        Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);
    }
}
