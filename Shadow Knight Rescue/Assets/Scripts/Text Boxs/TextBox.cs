using UnityEngine;

public class TextBox : MonoBehaviour
{
    public GameObject Text;
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
        if (collision.gameObject.name == "Shadow Knight")
        {
            isPlayerInRange = true;
            TextBox.SetActive(true);
        }

    }
    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.name == "Shadow Knight")
        {
            isPlayerInRange = false;
            TextBox.SetActive(false);
        }
    }

}
