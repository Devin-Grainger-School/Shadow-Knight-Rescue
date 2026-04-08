using UnityEngine;

public class MoveUp : MonoBehaviour
{
    public float speed = 20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // moves slugger up
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speed);
    }
}
