using UnityEngine;
using UnityEngine.SceneManagement;

public class Level02 : MonoBehaviour
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
    public bool Level1Door;
    public bool Level3Door;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Door1.active ==false && Door2.active ==false && Door3.active ==false && Door4.active ==false)
        {
            LevelComplete.SetActive(false);
            //Destroy(LevelComplete);
        }
        else
        {
            LevelComplete.SetActive(true);
        }
        //True Level1
        if (Level1Door && TrueStory && Input.GetKeyDown(KeyCode.Z) && isPlayerInRange)
        {
            LevelT1();
        }
        //Fake Level1
        if (Level1Door && FalseStory && Input.GetKeyDown(KeyCode.Z) && isPlayerInRange)
        {
            Level01();
        }
        //True Level3
        if (Level3Door && Input.GetKeyDown(KeyCode.Z) && TrueStory && isPlayerInRange)
        {
            LevelT3();
        }
        //Fake Level3
        if (Level3Door && FalseStory && Input.GetKeyDown(KeyCode.Z) && isPlayerInRange)
        {
            Level03();
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
    public void Level01()
    {
        //Start Fake Level 1
        SceneManager.LoadScene("Level 0-1");
    }
    public void LevelT1()
    {
        //Start True Level 1
        SceneManager.LoadScene("Level T-1");
    }
    public void Level03()
    {
        //Start Fake Level 1
        SceneManager.LoadScene("Level 0-3");
    }
    public void LevelT3()
    {
        //Start True Level 1
        SceneManager.LoadScene("Level T-3");
    }
}
