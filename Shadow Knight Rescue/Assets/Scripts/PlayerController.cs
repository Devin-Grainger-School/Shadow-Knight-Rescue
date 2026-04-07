using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public string Xaxis;
    public string Yaxis;
    public float horizontalInput;
    public float verticalInput;
    public float speed = 15.0f;
    public float xRange = 20;
    public Rigidbody rb;

    public GameObject projectilePrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        // Horizontal Movement Buttons for the Player
        horizontalInput = Input.GetAxis(Xaxis);
        // Horizontal Movement for the Player
        transform.Translate(Vector2.right * horizontalInput * Time.deltaTime * speed);
        // Verticle Movement
        verticalInput = Input.GetAxis(Yaxis);
        transform.Translate(Vector2.up * verticalInput * Time.deltaTime * speed);
        // Keeping Player in the box
        if (transform.position.x < -15)
        {
            transform.position = new Vector3(-15, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 15)
        {
            transform.position = new Vector3(15, transform.position.y, transform.position.z);
        }
        if (transform.position.y < -8)
        {
            transform.position = new Vector3(transform.position.x, -8, transform.position.z);
        }
        if (transform.position.y > 8)
        {
            transform.position = new Vector3(transform.position.x, 8, transform.position.z);
        }

        
    }
}
