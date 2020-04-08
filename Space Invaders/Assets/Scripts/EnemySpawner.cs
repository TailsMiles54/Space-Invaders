using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] Enemys1,Waypoints;

    void Start()
    {
        WaveStart();    
    }

    void WaveStart()
    {
        for (int i = 0; i < 10; i++)
        {
            Invoke("SpawnEnemy", 1);
        }
    }

    void SpawnEnemy()
    {
        GameObject EnemySpawned = Instantiate(Enemys1[Random.Range(0,3)]);
        EnemySpawned.transform.position = Waypoints[Random.Range(0,3)].transform.position;
    }
}
