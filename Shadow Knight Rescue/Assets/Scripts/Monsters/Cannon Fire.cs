using System.Collections;
using UnityEngine;

public class CannonFire : MonoBehaviour
{
    public GameObject FireBall;
    public bool Fires;
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
            yield return new WaitForSeconds(5);
            Fire();
        }

    }
    void Fire()
    {
        Instantiate(FireBall, transform.position, FireBall.transform.rotation);
        
    }
}
