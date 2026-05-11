using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class FireballTarget : MonoBehaviour
{
    public Transform target;
    public Vector3 last;
    public float speed = 20f;
    public float stopDistance = 0.1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = GameObject.Find("Shadow Knight").transform;
        last = new Vector3(target.position.x, target.position.y, target.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, last, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, last) < stopDistance)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        // Check if the object the projectile collided with has the "Enemy" tag
        if (other.CompareTag("Lamb") || other.CompareTag("Ground") || other.CompareTag("Clock"))
        {
            Debug.Log("Fireball Blocked");
            Destroy(gameObject);
        }
    }
}
