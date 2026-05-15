using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Collections;


public class Transition : MonoBehaviour
{
    public GameObject E;
    public bool TrueStory;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine("DotheThing");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator DotheThing()
    {
        if (E == true)
        {
            yield return new WaitForSeconds(1f);
            if (TrueStory)
            {
                Victory();
            }
            else
            {
                FVictory();
            }
        }
        else
        {
            StartCoroutine("DotheThing");
        }
            
    }
    public void Grow()
    {
        new WaitForSeconds(1f);
        SceneManager.LoadScene("Victory");
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
