using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cutscene : MonoBehaviour
{
    public bool TrueStory;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine("CutScene");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (TrueStory)
            {
                LevelTBoss();
            }
            else
            {
                LevelBoss();
            }
        }
    }
    public IEnumerator CutScene()
    {
        yield return new WaitForSeconds(18.5f);
        if (TrueStory)
        {
            LevelTBoss();
        }
        else
        {
            LevelBoss();
        }
    }
    public void LevelBoss()
    {
        //Opens Fake Tutorial
        SceneManager.LoadScene("Level Boss");
    }
    public void LevelTBoss()
    {
        //Opens True Tutorial
        SceneManager.LoadScene("Level True Boss");
    }
}
