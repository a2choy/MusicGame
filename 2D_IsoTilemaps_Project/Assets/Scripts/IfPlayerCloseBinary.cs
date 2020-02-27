using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfPlayerCloseBinary : MonoBehaviour
{
    InteractableBinarySwitch binSwitch;
    void Start()
    {
        binSwitch = this.transform.parent.GetComponent<InteractableBinarySwitch>();
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            binSwitch.activatable = true;
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            binSwitch.activatable = false;
        }
    }
}
