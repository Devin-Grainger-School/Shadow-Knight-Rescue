using UnityEngine;
using UnityEngine.InputSystem;

public class Text : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject KeyButton;
    public bool Talked;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider collision)
    {
        //MAkes interact button appear
        if (collision.gameObject.name == "Shadow Knight" && !Talked)
        {
            KeyButton.SetActive(true);
        }
        //Make interact button disappear
        if (collision.gameObject.name == "Shadow Knight" && Talked)
        {
            KeyButton.SetActive(false);
        }
        //Opens text box
        if (collision.gameObject.name == "Shadow Knight" && !Talked && Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("Can interact.");
            TextBox.SetActive(true);
            Talked = true;
        }
        //Closes text box
        if (collision.gameObject.name == "Shadow Knight" && Talked && Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("Can interact.");
            TextBox.SetActive(false);
        }
    }
}
