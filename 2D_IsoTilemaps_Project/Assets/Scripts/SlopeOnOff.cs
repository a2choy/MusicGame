using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlopeOnOff : MonoBehaviour
{
    public int color;
    bool redBool, blueBool, yellowBool;
    public GameObject gm;
    GameManagerScript gmScript;
    public GameObject slope;
    public GameObject baseTile;
    // Start is called before the first frame update
    void Start()
    {
        gmScript = gm.GetComponent<GameManagerScript>();
        redBool = gmScript.RedBool;
        blueBool = gmScript.BlueBool;
        yellowBool = gmScript.YellowBool;
    }

    // Update is called once per frame
    void Update()
    {
        redBool = gmScript.RedBool;
        blueBool = gmScript.BlueBool;
        yellowBool = gmScript.YellowBool;
        switch (color)
        {
            case 0:
                if(redBool)
                {
                    slope.SetActive(true);
                    baseTile.SetActive(false);
                }
                else
                {
                    slope.SetActive(false);
                    baseTile.SetActive(true);
                }
                
                break;
            case 1:
                if (blueBool)
                {
                    slope.SetActive(true);
                    baseTile.SetActive(false);
                }
                else
                {
                    slope.SetActive(false);
                    baseTile.SetActive(true);
                }
                break;
            case 2:
                if (yellowBool)
                {
                    slope.SetActive(true);
                    baseTile.SetActive(false);
                }
                else
                {
                    slope.SetActive(false);
                    baseTile.SetActive(true);
                }
                break;
        }
           

    }
}
