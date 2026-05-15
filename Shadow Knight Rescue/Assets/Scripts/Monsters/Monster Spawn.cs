using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class MonsterSpawn : MonoBehaviour
{
    public GameObject[] MonsterPrefabs;
    private float spawnRangeX = 31;
    private float spawnRangeZ = -.4f;
    public int startDelay = 0;
    public int spawnInterval = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine("SpawnRandomMonster");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public IEnumerator SpawnRandomMonster()
    {
        yield return new WaitForSeconds(spawnInterval);
        spawnInterval = Random.Range(3, 7);
        Vector3 spawnPos = new Vector3(Random.Range(spawnRangeX, spawnRangeX), 3.51f, 0);
        int monsterIndex = Random.Range(0, MonsterPrefabs.Length);
        Instantiate(MonsterPrefabs[Random.Range(0,4)], spawnPos, MonsterPrefabs[monsterIndex].transform.rotation);
        StartCoroutine("SpawnRandomMonster");
    }
}
