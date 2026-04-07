using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 15.0f;
    public float xRange = 20;

    public GameObject projectilePrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Horizontal Movement Buttons for the Player
        horizontalInput = Input.GetAxis("Horizontal");
        // Horizontal Movement for the Player
        transform.Translate(Vector2.right * horizontalInput * Time.deltaTime * speed);
        // Verticle Movement
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector2.up * verticalInput * Time.deltaTime * speed);
        // Keeping Player in the box
        if (transform.position.x < -20)
        {
            transform.position = new Vector3(-20, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 20)
        {
            transform.position = new Vector3(20, transform.position.y, transform.position.z);
        }
        if (transform.position.y < -2)
        {
            transform.position = new Vector3(transform.position.x, -2, transform.position.z);
        }
        if (transform.position.y > 20)
        {
            transform.position = new Vector3(transform.position.x, 20, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
