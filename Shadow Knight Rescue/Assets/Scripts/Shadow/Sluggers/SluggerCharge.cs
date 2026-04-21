using UnityEngine;


public class SluggerCharge : MonoBehaviour
{
    public int Slugger;
    public int Lambs;
    public int Nightingales;

    public GameObject[] SluggerPrefabs;
    public GameObject UpSlugger;
    public GameObject DownSlugger;
    public GameObject LeftSlugger;
    public GameObject RightSlugger;
    public GameObject Lamb;
    public GameObject Nightingale;

    public string ProjectileTag;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Slugger <= 1)
        {

            //Shadow
            if (Input.GetKeyDown(KeyCode.I))
            {
                // Launch a projectile from the player up
                Instantiate(UpSlugger, transform.position, UpSlugger.transform.rotation);
                //Slugger++;
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                // Launch a projectile from the player Down
                Instantiate(DownSlugger, transform.position, DownSlugger.transform.rotation);
                //Slugger++;
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                // Launch a projectile from the player Left
                Instantiate(LeftSlugger, transform.position, LeftSlugger.transform.rotation);
                //Slugger++;
            }
            if (Input.GetKeyDown(KeyCode.L))
            {
                // Launch a projectile from the player Right
                Instantiate(RightSlugger, transform.position, RightSlugger.transform.rotation);
                //Slugger++;
            }
            //Summons Lamb
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Instantiate(Lamb, transform.position, Lamb.transform.rotation);
            }
            //Summons Nightingale
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                Vector3 mousePos = Input.mousePosition;
                mousePos.z = 2.0f;       // we want 2m away from the camera position

                Vector3 objectPos = Camera.main.ScreenToWorldPoint(mousePos);
                Instantiate(Nightingale, objectPos, Nightingale.transform.rotation);
            }
        }
    }
}
