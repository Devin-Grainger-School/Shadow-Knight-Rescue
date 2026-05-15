using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class BossHealth : MonoBehaviour
{
    public int Health = 10;
    public SluggerCharge SluggerCharge;
    public GameObject WhiteBall;
    public GameObject E;
    public Material brightMaterial;
    public Material dimMaterial;
    public GameObject Hurt;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Health <= 0)
        {
            WhiteBall.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
            E.SetActive(true);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sluggers"))
        {
            Destroy(other.gameObject);
            //Debug.Log("Hit");
            SluggerCharge.Slugger--;
            //Debug.Log("Slugger down");
            Health -= 1;
            //Debug.Log("-1");
            Hurt.SetActive(true);
        }
    }
    public void Victory()
    {
        //Opens Victory
        SceneManager.LoadScene("Victory");
    }
    public void FVictory()
    {
        //Opens Fake Victory
        SceneManager.LoadScene("Fake Victory");
    }
}
