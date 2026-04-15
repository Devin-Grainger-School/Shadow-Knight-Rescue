using UnityEngine;
using UnityEngine.SceneManagement;

public class Level00 : MonoBehaviour
{
    public bool TrueStory;
    public bool TutorialTree;
    public bool Dungon;

    public GameObject TextBox;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TrueStory && TutorialTree && TextBox && Input.GetKeyDown(KeyCode.Z))
        {
            LevelTT();
        }
        else if (TutorialTree && TextBox && Input.GetKeyDown(KeyCode.Z))
        {
            Level0T();
        }
        if (TrueStory && Dungon && TextBox && Input.GetKeyDown(KeyCode.Z))
        {
            LevelT1();
        }
        else if (Dungon && TextBox && Input.GetKeyDown(KeyCode.Z))
        {
            Level01();
        }
    }
    //Enter Tutorial
    public void Level0T()
    {
        //States the Lore to the Player
        SceneManager.LoadScene("Level T");
    }
    public void LevelTT()
    {
        //States the Lore to the Player
        SceneManager.LoadScene("Tutorial");
    }
    //Enter Level 1
    public void Level01()
    {
        //States the Lore to the Player
        SceneManager.LoadScene("Level 0-1");
    }
    public void LevelT1()
    {
        //States the Lore to the Player
        SceneManager.LoadScene("Level T-1");
    }
    
}
