using UnityEngine;
using UnityEngine.InputSystem;

public class Text : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject KeyButton;
    public bool Talked;
    public bool Button;
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
        //Closes text box
        if (Talked && Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("Close.");
            TextBox.SetActive(false);
        }
        //Opens text box
        if (Input.GetKeyDown(KeyCode.Z) && Button)
        {
            Debug.Log("Open.");
            TextBox.SetActive(true);
            Talked = true;
        }
        
    }
    public void OnTriggerEnter(Collider collision)
    {
        //MAkes interact button appear
        if (collision.gameObject.name == "Shadow Knight" && !Talked)
        {
            KeyButton.SetActive(true);
            Button = true;
        }
        
    }
}
