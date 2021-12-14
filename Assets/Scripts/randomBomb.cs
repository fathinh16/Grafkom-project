using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomBomb : MonoBehaviour
{
    public GameObject bombs;
    public Transform[] spawnPoints;
    public float spawnRate;
    float nextSpawn = 0.0f;

    void Update() {
        if(Time.time > nextSpawn) {
            nextSpawn = Time.time + spawnRate;
//            randX = Random.Range(-406f, 406f);
            int randSpawnPoint = Random.Range(0, spawnPoints.Length);
            Instantiate(bombs, spawnPoints[randSpawnPoint].position, transform.rotation, transform);
        }
    }
}

