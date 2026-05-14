using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public bool TrueStory;
    public int Health = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Health <= 0)
        {
            if (TrueStory)
            {
                doTrueGameOver();
            }
            else
            {
                doGameOver();
            }
                Destroy(gameObject);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Monster"))
        {
            //Destroy(other.gameObject);
            Health -= 1;
        }
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
