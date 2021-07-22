using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    private float spawnRange = 6.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemys", 3, 10);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnEnemys()
    {
        int spawnCount = Random.Range(1, 4);
        for (int i = 0; i < spawnCount; i++)
        {
            int enemyIndex = Random.Range(0, enemyPrefabs.Length);

            float spawnPosX = Random.Range(-spawnRange, spawnRange);
            float spawnPosZ = Random.Range(-spawnRange, spawnRange);
            Vector3 spawnPos = new Vector3(spawnPosX, enemyPrefabs[enemyIndex].transform.position.y, spawnPosZ);

            Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);
        }
    }
}
