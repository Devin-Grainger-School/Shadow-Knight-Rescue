using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour
{
    public bool TrueStory;
    public bool FalseStory;
    public bool Flower;
    public bool isPlayerInRange = false;

    public GameObject Button;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (TrueStory && isPlayerInRange && Button && Input.GetKeyDown(KeyCode.Z))
        {
            LevelT0();
        }
        else if (Flower && isPlayerInRange && Input.GetKeyDown(KeyCode.Z))
        {
            Level0();
        }
    }
    //Enter Tutorial
    public void Level0()
    {
        //States the Lore to the Player
        SceneManager.LoadScene("Level 0-0");
    }
    public void LevelT0()
    {
        //States the Lore to the Player
        SceneManager.LoadScene("Level T-0");
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            isPlayerInRange = true;
        }
    }
    private void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            isPlayerInRange = false;
        }
    }
}
