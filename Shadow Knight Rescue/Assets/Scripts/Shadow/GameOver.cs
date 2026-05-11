using UnityEngine;

public class GameOver : MonoBehaviour
{
    public int Health = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Health == 0)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Monster"))
        {
            //Destroy(gameObject);
            Health--;
        }
    }
}
