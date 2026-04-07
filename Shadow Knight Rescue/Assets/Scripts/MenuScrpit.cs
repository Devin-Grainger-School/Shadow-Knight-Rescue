using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScrpit : MonoBehaviour
{
    public bool isGameActive;
    public TextMeshProUGUI gameOverText;
    
    private void Start()
    {
        
    }
    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            TrueLore();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            doExitGame();
        }
        //if (GameObject.FindGameObjectWithTag)

    }
    public void Lore()
    {
        SceneManager.LoadScene("Lore");
    }
    public void TrueLore()
    {
        SceneManager.LoadScene("Game");
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

}