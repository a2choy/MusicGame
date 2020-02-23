using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public GameObject options;
    [SerializeField] int state = 1;
    // Start is called before the first frame update
    void Start()
    {
        
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
                state = 0;
            }
            else if (colYellow.bounds.Contains(wp))
            {
                state = 1;
            }
            else if (colGreen.bounds.Contains(wp))
            {
                state = 2;
            }
        }
        switch (state)
        {
            case 0:
                //do sth
                break;
            case 1:
                //do sth
                break;
            case 2:
                //do sth
                break;
            default:
                break;
        }
    }
}
