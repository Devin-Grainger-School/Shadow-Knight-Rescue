using UnityEngine;

public class MoveRight : MonoBehaviour
{
    public float speed = 20.0f;
    // Moves slugger right
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed);
    }
}
