using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using Unity.VisualScripting;

public class Damage : MonoBehaviour
{
    public GameObject Hurt;
    // Update is called once per frame
    void Update()
    {
        StartCoroutine("Hurts");
    }
    public IEnumerator Hurts()
    {
        yield return new WaitForSeconds(.5f);
        Hurt.SetActive(false);
        
    }
}
