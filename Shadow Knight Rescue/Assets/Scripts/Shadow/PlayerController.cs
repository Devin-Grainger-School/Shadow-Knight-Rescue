using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10f;
    public float jumpForce = 10;
    public float xRange = 20;
    public float jump = 1;

    public GameObject projectilePrefab;
    private Rigidbody playerRb;

    InputAction moveAction;
    private Vector2 movementVector;

    public float gravityModifier;
    public bool isOnGround = true;

    public GameObject TextBox;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        //Physics.gravity *= gravityModifier;
        moveAction = InputSystem.actions.FindAction("Horizontal");
    }

    // Update is called once per frame
    void Update()
    {
        //Spirt Sleeper Movement
        //movementVector = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        //playerRb.linearVelocity = movementVector.normalized * speed;
        
        //Add Force Movement
        //playerRb.AddForce(movementVector.normalized * speed, ForceMode.Acceleration);
        //playerRb.AddRelativeForce(movementVector.normalized * speed);
        
        //Transform Movement
        // Horizontal Movement Buttons for the Player
        horizontalInput = Input.GetAxis("Horizontal");
        // Horizontal Movement for the Player
        transform.Translate(Vector2.right * horizontalInput * Time.deltaTime * speed);
        // Jump
        if (Input.GetKeyDown(KeyCode.Space) && jump != 0)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            jump--;
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
            jump = 1;
        }
    }

}
