using UnityEngine;

public class PlayerInteractor : MonoBehaviour
{
    public Transform target;
    private float minDistance = 1f;
    private float range;
    public float speed = 200f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = GameObject.Find("Shadow Knight").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < 12.5f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 12.5f);
        }
        transform.position = target.position;
        range = Vector2.Distance(transform.position, target.position);

        if (range > minDistance)
        {
            Debug.Log(range);

            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            transform.position = target.position;
        }
        
    }
}
