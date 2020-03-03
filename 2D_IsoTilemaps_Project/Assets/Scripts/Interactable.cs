using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public GameObject options;
    public GameObject gm;
    GameManagerScript gmScript;
    //int prevState = -1;
    //[SerializeField] int state = 1;
    // Start is called before the first frame update
    public bool activatable = true;
    void Start()
    {
        gmScript = gm.GetComponent<GameManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            wp = new Vector3(wp.x, wp.y, 0);

            CircleCollider2D colRed = options.transform.Find("ColRed").gameObject.GetComponent<CircleCollider2D>();
            CircleCollider2D colYellow = options.transform.Find("ColYellow").gameObject.GetComponent<CircleCollider2D>();
            CircleCollider2D colGreen = options.transform.Find("ColGreen").gameObject.GetComponent<CircleCollider2D>();

            if (colRed.bounds.Contains(wp))
            {
                //state = 0;
                /*if(prevState == 0)
                {
                    gmScript.Red--;
                }
                else if(prevState == 1)
                {
                    gmScript.Blue--;
                }
                else if (prevState == 2)
                {
                    gmScript.Yellow--;
                }
                
                gmScript.Red++;
                prevState = 0;
                */
                /*if (gmScript.Red > 0)
                    gmScript.RedBool = true;
                else
                    gmScript.RedBool = false;
                */
                gmScript.RedBool = true;
                activatable = false;
                options.SetActive(false);
            }
            else if (colYellow.bounds.Contains(wp))
            {
                //state = 1;
                /*
                if (prevState == 0)
                {
                    gmScript.Red--;
                }
                else if (prevState == 1)
                {
                    gmScript.Blue--;
                }
                else if (prevState == 2)
                {
                    gmScript.Yellow--;
                }

                gmScript.Blue++;
                prevState = 1;
                */
                gmScript.BlueBool = true;
                activatable = false;
                options.SetActive(false);
            }
            else if (colGreen.bounds.Contains(wp))
            {
                //state = 2;
                /*
                if (prevState == 0)
                {
                    gmScript.Red--;
                }
                else if (prevState == 1)
                {
                    gmScript.Blue--;
                }
                else if (prevState == 2)
                {
                    gmScript.Yellow--;
                }

                gmScript.Yellow++;
                prevState = 2;
                */
                gmScript.YellowBool = true;
                activatable = false;
                options.SetActive(false);
            }
            
        }
    }
}
