using UnityEngine;

public class Lamb : MonoBehaviour
{
    public Transform target;
    public float speed = 200f;
    private float minDistance = 1f;
    private float range;
    public int charge = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = GameObject.Find("Shadow Knight").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //Destroy(gameObject);
            charge = 1;
            
        }
        if (charge > 0)
        {
            range = Vector2.Distance(transform.position, target.position);

            if (range > minDistance)
            {
                Debug.Log(range);

                transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            }
        }
    }
    public void OnTriggerEnter(Collider collision)
    {
        if (charge > 0)
        {
            Destroy(gameObject);
        }
    }
}
