using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlopeOnOff : MonoBehaviour
{
    public int color;
    int red, blue, yellow;
    public GameObject gm;
    GameManagerScript gmScript;
    public GameObject slope;
    public GameObject baseTile;
    // Start is called before the first frame update
    void Start()
    {
        gmScript = gm.GetComponent<GameManagerScript>();
        red = gmScript.Red;
        blue = gmScript.Blue;
        yellow = gmScript.Yellow;
    }

    // Update is called once per frame
    void Update()
    {
        red = gmScript.Red;
        blue = gmScript.Blue;
        yellow = gmScript.Yellow;
        switch (color)
        {
            case 0:
                if(red > 0)
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
                if (blue > 0)
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
                if (yellow > 0)
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
