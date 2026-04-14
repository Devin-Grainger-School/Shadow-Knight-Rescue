using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 1500.0f;
    public float jumpForce = 10;
    public float xRange = 20;

    public GameObject projectilePrefab;
    private Rigidbody playerRb;
    public float gravityModifier;
    public bool isOnGround = true;

    public GameObject TextBox;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        //Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        // Horizontal Movement Buttons for the Player
        horizontalInput = Input.GetAxis("Horizontal");
        // Horizontal Movement for the Player
        playerRb.AddForce(Vector2.right * horizontalInput * Time.deltaTime * speed);
        // Jump
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }

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
    //Checks if the player is touching the ground
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }

}
