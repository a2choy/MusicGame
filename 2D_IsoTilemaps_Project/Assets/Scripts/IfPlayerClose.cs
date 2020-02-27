using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfPlayerClose : MonoBehaviour
{
    public GameObject options;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player" && this.transform.parent.GetComponent<Interactable>().activatable)
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
