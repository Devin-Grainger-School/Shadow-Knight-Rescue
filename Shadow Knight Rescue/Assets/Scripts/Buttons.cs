using UnityEngine;

public class Buttons : MonoBehaviour
{
    public bool Button1;
    public bool Button1Pushed = false;
    public bool Button2;
    public bool Button2Pushed = false;

    public bool Door;
    public gameObject Door;

    public bool isPlayerInRange = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.Z))
            {
                Debug.Log("Pushed");
                Door.SetActive(false);
            }
    }
    public void OnTriggerEnter(Collider collision)
    {
        //MAkes interact button appear
        if (collision.gameObject.name == "Shadow Knight" && Button1)
        {
                isPlayerInRange = true;
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
}
