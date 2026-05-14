using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScrpit : MonoBehaviour
{
    public bool isMenu;
    public bool isGame;
    public bool TrueStory;
    public TextMeshProUGUI gameOverText;
    public GameObject livecharac;

    private void Start()
    {
        
    }
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Boss();
        }
        //Starts the true game
        if (Input.GetKeyDown(KeyCode.P))
        {
            TrueLore();
        }
        //Ends Game
        if (Input.GetKeyDown(KeyCode.Escape) && isMenu)
        {
            doExitGame();
        }
        if (Input.GetKeyDown(KeyCode.Escape) && isGame)
        {
            SceneManager.LoadScene("TitleScreen");
        }
        if (!livecharac && TrueStory && isGame || Input.GetKeyDown(KeyCode.G))
        {
            doTrueGameOver();
        }
        else if (!livecharac && isGame || Input.GetKeyDown(KeyCode.G))
        {
            doGameOver();
        }

    }
    public void PlayStory()
    {
        //States the Lore to the Player
        SceneManager.LoadScene("Story");
    }
    public void TrueLore()
    {
        //States the true story to the player
        SceneManager.LoadScene("True Story");
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("Level 0-0");
    }
    public void PlayTrueGame()
    {
        SceneManager.LoadScene("Level T-0");
    }
    public void doExitGame()
    {
        Application.Quit();
    }
    public void doGameOver()
    {
        SceneManager.LoadScene("Game Over");
    }
    public void doTrueGameOver()
    {
        SceneManager.LoadScene("True Game Over");
    }
    public void Boss()
    {
        SceneManager.LoadScene("True Cutscene");
    }
}