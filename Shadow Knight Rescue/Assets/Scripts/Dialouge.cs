using UnityEngine;
using UnityEngine.InputSystem;

public class Text : MonoBehaviour
{
    public GameObject TextBox;
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
        if (collision.gameObject.name == "Shadow Knight" && Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("Can interact.");
            TextBox.SetActive(true);
          if (Input.GetKeyDown(KeyCode.Z))
            {
                TextBox.SetActive(false);
            }
        }
    }
}
