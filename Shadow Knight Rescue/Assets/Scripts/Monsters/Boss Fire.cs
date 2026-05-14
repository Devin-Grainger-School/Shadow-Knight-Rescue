using System.Collections;
using UnityEngine;

public class BossFire : MonoBehaviour
{
    public GameObject FireBall;
    public bool Fires;
    public int rSec;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Fired());
    }

    // Update is called once per frame
    void Update()
    {
        //StartCoroutine("Fired");
        //Invoke("Fire", 2.0f);
    }
    IEnumerator Fired()
    {
        while (true)
        {
            rSec = Random.Range(1, 3);
            yield return new WaitForSeconds(rSec);
            Fire();
        }

    }
    void Fire()
    {
        Instantiate(FireBall, transform.position, FireBall.transform.rotation);

    }
}
