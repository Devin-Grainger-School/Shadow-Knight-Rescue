using UnityEngine;
using UnityEngine.SceneManagement;

public class Level03 : MonoBehaviour
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
    public bool Level2Door;
    public bool Level4Door;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!Door1 && !Door2 && !Door3 && !Door4)
        {
            LevelComplete.SetActive(false);
            //Destroy(LevelComplete);
        }
        else
        {
            LevelComplete.SetActive(true);
        }
        //True Level2
        if (Level2Door && TrueStory && Input.GetKeyDown(KeyCode.Z) && isPlayerInRange)
        {
            LevelT2();
        }
        //Fake Level2
        if (Level2Door && FalseStory && Input.GetKeyDown(KeyCode.Z) && isPlayerInRange)
        {
            Level02();
        }
        //True Cutscene
        if (Level4Door && Input.GetKeyDown(KeyCode.Z) && TrueStory && isPlayerInRange)
        {
            TCutScene();
        }
        //Fake CutScene
        if (Level4Door && FalseStory && Input.GetKeyDown(KeyCode.Z) && isPlayerInRange)
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
    public void Level02()
    {
        //Start Fake Level 2
        SceneManager.LoadScene("Level 0-2");
    }
    public void LevelT2()
    {
        //Start True Level 2
        SceneManager.LoadScene("Level T-2");
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
