using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float speed = 20.0f;
    // move slugger down
    void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * speed);
    }
}
