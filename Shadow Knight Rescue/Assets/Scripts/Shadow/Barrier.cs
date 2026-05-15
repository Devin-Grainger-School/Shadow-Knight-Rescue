using UnityEngine;
using UnityEngine.UIElements;

public class Barrier : MonoBehaviour
{
    public Transform target;
    public float speed = 20000f;
    private float minDistance = 1f;
    private float range;
    public GameOver Health;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = GameObject.Find("Shadow Knight").transform;
    }

    // Update is called once per frame
    void Update()
    {
        range = Vector2.Distance(transform.position, target.position);

        if (range > minDistance)
        {


            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            //gainmomentum();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Monster") || other.CompareTag("Bull"))
        {
            Health.Health++;
            Debug.Log("Fireball Blocked");
            Destroy(other.gameObject);
            gameObject.SetActive(false);
        }
    }
}
