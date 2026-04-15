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
        if (!livecharac && TrueStory || Input.GetKeyDown(KeyCode.G))
        {
            doTrueGameOver();
        }
        else if (!livecharac || Input.GetKeyDown(KeyCode.G))
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
        SceneManager.LoadScene("Level 0-1");
    }
    public void PlayTrueGame()
    {
        SceneManager.LoadScene("Level T-1");
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
}