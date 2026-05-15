using NUnit.Framework;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    public Texture2D cursorArrow;
    public Texture2D cursorArrowUpdate;
    [SerializeField]
    //private List<GameObject> _clickSpell = new List<GameObject>();
    private Camera _cam;
    [SerializeField]
    private AudioClip _clickClip;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
        _cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //Cursor.SetCursor(cursorArrowUpdate, Vector2.zero, CursorMode.ForceSoftware);
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            //Cursor.SetCursor(cursorArrowUpdate, Vector2.zero, CursorMode.ForceSoftware);
        }
    }
}
