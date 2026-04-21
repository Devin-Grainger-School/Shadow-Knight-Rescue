using UnityEngine;
using UnityEngine.SceneManagement;

public class Level01 : MonoBehaviour
{
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
        if (gameObject.name == "Shadow Knight")
        {
            DemoEnd();
        }
        
    }
    public void DemoEnd()
    {
        //States the Lore to the Player
        SceneManager.LoadScene("Demo End");
    }
}
