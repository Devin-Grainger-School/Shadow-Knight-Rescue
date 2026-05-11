using UnityEngine;

public class BullCharge : MonoBehaviour
{
    public Transform target;
    public float speed = 200f;
    private float minDistance = 1f;
    private float range;
    private Rigidbody monsterRb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = GameObject.Find("Shadow Knight").transform;
        monsterRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 2.73)
        {
            transform.position = new Vector3(transform.position.x, 2.73f, transform.position.z);
        }
        range = Vector2.Distance(transform.position, target.position);

        if (range > minDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            //gainmomentum();
        }
    }
    void gainmomentum()
    {
        monsterRb.AddForce(target.position * speed, ForceMode.Acceleration);
    }
}
