using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class BirdSpawner : MonoBehaviour
{
    public GameObject[] MonsterPrefabs;
    private float spawnRangeX = 31;
    private float spawnRangeZ = -.4f;
    public int startDelay = 0;
    public int spawnInterval = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine("SpawnRandomBird");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator SpawnRandomBird()
    {
        yield return new WaitForSeconds(spawnInterval);
        spawnInterval = Random.Range(3, 7);
        Vector3 spawnPos = new Vector3(Random.Range(-15.63f, 74.2f), 52f, 0);
        int monsterIndex = Random.Range(0, MonsterPrefabs.Length);
        Instantiate(MonsterPrefabs[Random.Range(0, MonsterPrefabs.Length)], spawnPos, MonsterPrefabs[monsterIndex].transform.rotation);
        StartCoroutine("SpawnRandomBird");
    }
}
