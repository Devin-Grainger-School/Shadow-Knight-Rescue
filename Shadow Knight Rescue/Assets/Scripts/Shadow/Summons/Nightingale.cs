using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Nightingale : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine("SelfDestruction");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, -1f);
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Destroy(gameObject);
        }
    }
    public IEnumerator SelfDestruction()
    {
        yield return new WaitForSeconds(1f);
        //Destroy(gameObject);
    }
}
