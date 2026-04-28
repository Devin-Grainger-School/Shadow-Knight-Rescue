using UnityEngine;
using UnityEngine.SceneManagement;

public class Level00 : MonoBehaviour
{
    public bool TrueStory;
    public bool FalseStory;
    public bool TutorialTree;
    public bool Dungon;

    public GameObject TextBox;
    public bool isPlayerInRange = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TrueStory && TutorialTree && TextBox && isPlayerInRange && Input.GetKeyDown(KeyCode.Z))
        {
            LevelTT();
        }
        else if (TutorialTree && FalseStory && TextBox && isPlayerInRange && Input.GetKeyDown(KeyCode.Z))
        {
            Level0T();
        }
        if (TrueStory && Dungon && TextBox && isPlayerInRange && Input.GetKeyDown(KeyCode.Z))
        {
            LevelT1();
        }
        else if (Dungon && FalseStory && TextBox && isPlayerInRange && Input.GetKeyDown(KeyCode.Z))
        {
            Level01();
        }
    }
    //Enter Tutorial
    public void Level0T()
    {
        //Opens Fake Tutorial
        SceneManager.LoadScene("Level T");
    }
    public void LevelTT()
    {
        //Opens True Tutorial
        SceneManager.LoadScene("Tutorial");
    }
    //Enter Level 1
    public void Level01()
    {
        //Opens Fake Level 1
        SceneManager.LoadScene("Level 0-1");
    }
    public void LevelT1()
    {
        //Opens True Level 1
        SceneManager.LoadScene("Level T-1");
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
