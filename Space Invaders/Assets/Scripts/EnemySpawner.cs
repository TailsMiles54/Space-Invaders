using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] Enemys1,Waypoints;
    public GameObject Canvas;
    private GameUI GameUI;
    private int MaxWave = 10;
    
    void Start()
    {
        GameUI = Canvas.GetComponent<GameUI>();
        StartCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy() {
        for (int wave = 1; wave <= MaxWave; wave++)
        {
            GameUI.Level = wave;
            GameUI.UIUpdate();
            for (int i = 0; i < 10; i++) {
                        GameObject EnemySpawned = Instantiate(Enemys1[Random.Range(0,3)]);
                        EnemySpawned.transform.position = Waypoints[Random.Range(0,3)].transform.position;
                        EnemySpawned.transform.localScale = new Vector3(0.75f,0.75f);
                        EnemySpawned.GetComponent<SpriteRenderer>().sortingLayerName = "Bullet + Enemy";
                        yield return new WaitForSeconds(.5f);
            }
            yield return new WaitForSeconds(3f);
        }
    }
}
