using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableBinarySwitch : MonoBehaviour
{
    public GameObject col;
    public GameObject onOff;
    public GameObject gm;
    static bool globalState;
    GameManagerScript gmScript;
    public bool activatable = false; 

    //[SerializeField] int state = 1;
    // Start is called before the first frame update
    void Start()
    {
        gmScript = gm.GetComponent<GameManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetMouseButtonDown(0) && activatable)
        {
            Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            wp = new Vector3(wp.x, wp.y, 0);

            CircleCollider2D colRed = col.GetComponent<CircleCollider2D>();


            if (colRed.bounds.Contains(wp))
            {

                gmScript.RedBool = !gmScript.RedBool;
                globalState = !globalState;
            }
        }

        if (globalState)
        {
            onOff.SetActive(true);
        }
        else
        {
            onOff.SetActive(false);
        }
    }
}
