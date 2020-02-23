using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfPlayerClose : MonoBehaviour
{
    public GameObject options;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            options.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            options.SetActive(false);
        }
    }
}
