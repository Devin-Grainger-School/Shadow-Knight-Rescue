using UnityEngine;

public class Buttons : MonoBehaviour
{
    public bool Button1;
    public bool Button1Pushed = false;
    public GameObject button1;
    public GameObject button1Pushed;
    public bool Button2;
    public bool Button2Pushed = false;
    public GameObject button2;
    public GameObject button2Pushed;

    public bool Door;
    public GameObject door;

    public bool isPlayerInRange = false;
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
        //
        if (collision.gameObject.name == "Shadow Knight" || collision.gameObject.name == "Shadow Lamb" && Button1)
        {
                isPlayerInRange = true;
                Debug.Log("Pushed");
                door.SetActive(false);
                //button1.SetActive(false);
                //button1Pushed.SetActive(true);
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (gameObject.name == "Shadow Knight" || gameObject.name == "Shadow Lamb" && Button1)
        {
            isPlayerInRange = false;
            Debug.Log("Pushed");
            door.SetActive(true);
            //button1.SetActive(true);
            //button1Pushed.SetActive(false);
        }
    }
}
