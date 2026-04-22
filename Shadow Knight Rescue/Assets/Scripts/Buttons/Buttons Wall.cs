using UnityEngine;

public class ButtonsWall : MonoBehaviour
{
    
    public bool Button2;
    public bool Button2Pushed = false;
    public GameObject button2;
    public GameObject button2Pushed;

    public GameObject door;

    public bool isPlayerInRange = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayerInRange && !door && Input.GetKeyDown(KeyCode.Z))
        {
            door.SetActive(true);
            button2.SetActive(true);
            button2Pushed.SetActive(false);
            Button2Pushed = false;
        }
        //Wall Button
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.Z))
        {
            button2.SetActive(false);
            button2Pushed.SetActive(true);
            door.SetActive(false);
            Button2Pushed = true;
        }
        
    }
    public void OnTriggerEnter(Collider collision)
    {
        //
        if (collision.gameObject.name == "Shadow Knight")
        {
            isPlayerInRange = true;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (gameObject.name == "Shadow Knight")
        {
            isPlayerInRange = false;
        }
    }
}
