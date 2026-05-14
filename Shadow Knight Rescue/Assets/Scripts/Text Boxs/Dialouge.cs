using UnityEngine;
using UnityEngine.InputSystem;

public class Text : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject KeyButton;
    public bool Talked;
    public bool Button;
    public bool isPlayerInRange = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Make interact button disappear
        if (Talked)
        {
            KeyButton.SetActive(false);
        }
        
        if (Input.GetKeyDown(KeyCode.Z))
        {
            //Closes text box
            if (Talked)
            {
                Debug.Log("Close.");
                TextBox.SetActive(false);
            }
            //Opens text box
            if (isPlayerInRange && !Talked)
            {
                Debug.Log("Open.");
                TextBox.SetActive(true);
                Talked = true;
            }
        }
        
        
    }
    public void OnTriggerEnter(Collider collision)
    {
        //MAkes interact button appear
        if (collision.gameObject.name == "Shadow Knight" && !Talked)
        {
                isPlayerInRange = true;
                KeyButton.SetActive(true);
                Button = true;
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = false;
            KeyButton.SetActive(false);
        }
    }
}
