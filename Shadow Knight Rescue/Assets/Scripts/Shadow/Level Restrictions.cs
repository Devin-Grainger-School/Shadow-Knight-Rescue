using UnityEngine;

public class LevelRestrictions : MonoBehaviour
{
    public float negxaxis = 0;
    public float xaxis = 0;
    public float negyaxis = 0;
    public float yaxis = 0;

    public GameObject LevelComplete;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Keeping Player in the box
        if (transform.position.x < negxaxis)
        {
            transform.position = new Vector3(negxaxis, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xaxis)
        {
            transform.position = new Vector3(xaxis, transform.position.y, transform.position.z);
        }
        if (transform.position.y < negyaxis)
        {
            //transform.position = new Vector3(transform.position.x, negyaxis, transform.position.z);
        }
        if (transform.position.y > yaxis)
        {
            transform.position = new Vector3(transform.position.x, yaxis, transform.position.z);
        }
        if (LevelComplete.active == false)
        {
            negxaxis = -20;
        }
    }
}
