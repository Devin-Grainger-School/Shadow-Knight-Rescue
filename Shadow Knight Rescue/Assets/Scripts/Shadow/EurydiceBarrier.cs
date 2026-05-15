using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class EurydiceBarrier : MonoBehaviour
{
    public GameObject Barrier;
    public int spawnInterval = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine("SpawnBarrier");
    }

    // Update is called once per frame
    void Update()
    {

    }
    public IEnumerator SpawnBarrier()
    {
        yield return new WaitForSeconds(spawnInterval);
        spawnInterval = Random.Range(2, 5);
        Barrier.SetActive(true);
        StartCoroutine("SpawnBarrier");
    }
}
