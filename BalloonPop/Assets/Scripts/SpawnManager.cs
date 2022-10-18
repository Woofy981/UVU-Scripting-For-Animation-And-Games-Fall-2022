using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] balloonPrefabs;
    public float startDelay = 0.5f, spawnInterval = 1.5f, xRange = 45;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBalloon", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomBalloon()
    {
        // get random x position
        Vector3 spawnPosX = new Vector3(Random.Range(-xRange, xRange), 0, 0);

        // pick random balloon
        int balloonIndex = Random.Range(0, balloonPrefabs.Length);

        // spawn random balloon
        Instantiate(balloonPrefabs[balloonIndex], spawnPosX, balloonPrefabs[balloonIndex].transform.rotation);
    }
}
