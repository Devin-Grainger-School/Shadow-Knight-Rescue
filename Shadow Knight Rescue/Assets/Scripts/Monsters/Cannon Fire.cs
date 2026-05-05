using System.Collections;
using UnityEngine;

public class CannonFire : MonoBehaviour
{
    public GameObject FireBall;
    public bool Fires;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //StartCoroutine("Fired");
        Invoke("Fire", 2.0f);
    }
    void Fired()
    {
        if (FireBall != null) 
        {
            //Fires = 1;
        }
    }
    void Fire()
    {
        Instantiate(FireBall, transform.position, FireBall.transform.rotation);
    }
}
