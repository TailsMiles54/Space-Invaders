using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] Enemys1,Waypoints;
    private int i;
    
    void Start()
    {
        StartCoroutine(SpawnEnemy());    
    }

    IEnumerator SpawnEnemy() {
        for (int i = 0; i < 10; i++) {
            GameObject EnemySpawned = Instantiate(Enemys1[Random.Range(0,3)]);
            EnemySpawned.transform.position = Waypoints[Random.Range(0,3)].transform.position;
            EnemySpawned.transform.localScale = new Vector3(0.75f,0.75f);
            yield return new WaitForSeconds(.5f);
        }        
    }
}
