using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class Victory : MonoBehaviour
{
    public GameObject Text;
    public GameObject WhiteBall;
    public bool White;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine("WhieBall");
    }

    // Update is called once per frame
    void Update()
    {
        if (White)
        {
            WhiteBall.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
        }
        
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Text.SetActive(false);
        }
    }
    public IEnumerator WhieBall()
    {
        yield return new WaitForSeconds(.15f);
        Destroy(WhiteBall);
    }
}
