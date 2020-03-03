using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsometricPlayerMovementController : MonoBehaviour
{

    private Vector2 mousePosition;
    public float movementSpeed = 1f;
    IsometricCharacterRenderer isoRenderer;

    Rigidbody2D rbody;

    private void Awake()
    {
        rbody = GetComponent<Rigidbody2D>();
        isoRenderer = GetComponentInChildren<IsometricCharacterRenderer>();
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 currentPos = rbody.position;
        if (Input.GetMouseButton(0)) 
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = Vector2.MoveTowards(transform.position, mousePosition, movementSpeed*Time.deltaTime);
            isoRenderer.SetDirection(mousePosition);
        }
        if (!Input.GetMouseButton(0)) 
        {
            isoRenderer.SetDirection(new Vector2(0, 0));
        }
    }
}
