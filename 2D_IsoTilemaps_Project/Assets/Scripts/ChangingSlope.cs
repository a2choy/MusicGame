using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingSlope : MonoBehaviour
{
    int state = 0;
    public GameObject gm;
    GameManagerScript gmScript;
    public GameObject slope;
    public GameObject baseTile;
    // Start is called before the first frame update
    void Start()
    {
        gmScript = gm.GetComponent<GameManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        state = gmScript.State;
        switch (state)
        {
            case 0:
                slope.SetActive(false);
                baseTile.SetActive(true);
                break;
            case 1:
                slope.SetActive(true);
                baseTile.SetActive(false);
                break;
            case 2:
                slope.SetActive(true);
                baseTile.SetActive(false);
                break;
            default:
                break;
        }
    }
}
