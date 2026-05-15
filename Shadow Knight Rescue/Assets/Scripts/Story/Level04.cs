using UnityEngine;
using UnityEngine.SceneManagement;

public class Level04 : MonoBehaviour
{
    public GameObject LevelComplete;
    public GameObject Door1;
    public GameObject Door2;
    public GameObject Door3;
    public GameObject Door4;

    public GameObject KeyButton;
    public bool isPlayerInRange = false;
    public bool TrueStory;
    public bool FalseStory;
    public bool Level3Door;
    public bool Level5Door;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Door1.active == false && Door2.active == false && Door3.active == false && Door4.active == false)
        {
            LevelComplete.SetActive(false);
            //Destroy(LevelComplete);
        }
        else
        {
            LevelComplete.SetActive(true);
        }
        //True Level3
        if (Level3Door && TrueStory && Input.GetKeyDown(KeyCode.Z) && isPlayerInRange)
        {
            LevelT3();
        }
        //Fake Level3
        if (Level3Door && FalseStory && Input.GetKeyDown(KeyCode.Z) && isPlayerInRange)
        {
            Level03();
        }
        //True Cutscene
        if (Level5Door && Input.GetKeyDown(KeyCode.Z) && TrueStory && isPlayerInRange)
        {
            TCutScene();
        }
        //Fake CutScene
        if (Level5Door && FalseStory && Input.GetKeyDown(KeyCode.Z) && isPlayerInRange)
        {
            CutScene();
        }
    }
    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Shadow Knight")
        {
            isPlayerInRange = true;
            KeyButton.SetActive(true);
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
    public void Level03()
    {
        //Start Fake Level 3
        SceneManager.LoadScene("Level 0-3");
    }
    public void LevelT3()
    {
        //Start True Level 3
        SceneManager.LoadScene("Level T-3");
    }
    public void CutScene()
    {
        //Start Fake Cutscene
        SceneManager.LoadScene("Cutscene");
    }
    public void TCutScene()
    {
        //Start True Cutscene
        SceneManager.LoadScene("True Cutscene");
    }
}
