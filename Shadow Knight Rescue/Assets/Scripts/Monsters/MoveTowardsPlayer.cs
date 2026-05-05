using UnityEngine;

public class MoveTowardsPlayer : MonoBehaviour
{
    public Transform target;
    public float speed = 2f;
    private float minDistance = 1f;
    private float range;
    private Rigidbody monsterRb;
    
    private void Start()
    {
        target = GameObject.Find("Shadow Knight").transform;
        monsterRb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        range = Vector2.Distance(transform.position, target.position);

        if (range > minDistance)
        {


            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            //gainmomentum();
        }
    }
    void gainmomentum()
    {
        monsterRb.AddRelativeForce(target.position * speed, ForceMode.Acceleration);
    }

}
