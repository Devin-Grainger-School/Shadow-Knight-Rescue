using UnityEngine;

public class BossHealth : MonoBehaviour
{
    public int Health = 10;
    public SluggerCharge SluggerCharge;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Slugger"))
        {
            
            Destroy(other.gameObject);
            Debug.Log("Hit");
            SluggerCharge.Slugger--;
            Debug.Log("Slugger down");
            Health -= 1;
            Debug.Log("-1");
        }
    }
}
