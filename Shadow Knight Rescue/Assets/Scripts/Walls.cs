using UnityEngine;

public class Walls : MonoBehaviour
{
    public SluggerCharge SluggerCharge;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sluggers"))
        {
            Destroy(other.gameObject);
            SluggerCharge.Slugger--;
        }
    }
}
