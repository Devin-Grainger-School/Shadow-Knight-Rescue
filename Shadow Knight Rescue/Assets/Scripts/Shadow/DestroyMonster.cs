using UnityEngine;

public class DestroyMonster : MonoBehaviour
{
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
        // Check if the object the projectile collided with has the "Enemy" tag
        if (other.CompareTag("Respawn"))
        {
            Destroy(gameObject);

        }
    }
}
