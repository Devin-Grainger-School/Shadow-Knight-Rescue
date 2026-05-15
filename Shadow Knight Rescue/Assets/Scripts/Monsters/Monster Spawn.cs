using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class MonsterSpawn : MonoBehaviour
{
    public GameObject[] MonsterPrefabs;
    public float spawnRangeX = 31;
    public float spawnRangeNegX = 31;
    public float spawnRangeY = 3.51f;
    public int Random1 = 3;
    public int Random2 = 7;
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
        spawnInterval = Random.Range(Random1, Random2);
        Vector3 spawnPos = new Vector3(Random.Range(spawnRangeNegX, spawnRangeX), spawnRangeY, 0);
        int monsterIndex = Random.Range(0, MonsterPrefabs.Length);
        Instantiate(MonsterPrefabs[Random.Range(0,4)], spawnPos, MonsterPrefabs[monsterIndex].transform.rotation);
        StartCoroutine("SpawnRandomMonster");
    }
}
