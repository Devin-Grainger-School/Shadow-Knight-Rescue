using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 15.0f;
    public float xRange = 20;

    public GameObject projectilePrefab;

    public GameObject TextBox;

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
            //transform.position = new Vector3(transform.position.x, -2, transform.position.z);
        }
        if (transform.position.y > 20)
        {
            transform.position = new Vector3(transform.position.x, 20, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            //horizontalInput = "false";
        }
    }
        //Text Box opens
        public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "PAge_0")
        {
            Debug.Log("Can interact.");
            TextBox.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Z))
            {
                TextBox.SetActive(false);
            }
        }
        if (collision.gameObject.name == "Leave")
        {
            Debug.Log("Can interact.");
            TextBox.SetActive(false);
        }
    }
}
