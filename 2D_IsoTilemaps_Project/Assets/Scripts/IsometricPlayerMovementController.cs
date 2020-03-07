using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsometricPlayerMovementController : MonoBehaviour
{

    private Vector2 mousePosition;
    public float movementSpeed = 1f;
    IsometricCharacterRenderer isoRenderer;

    [SerializeField] GameObject pauseButton;

    [SerializeField] bool canMove = true;

    Rigidbody2D rbody;

    private void Awake()
    {
        rbody = GetComponent<Rigidbody2D>();
        isoRenderer = GetComponentInChildren<IsometricCharacterRenderer>();
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 currentPos = rbody.position;

        //Check if pause menu is active or if mouse is over pause button
        if (Input.GetMouseButton(0) && canMove && !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject()) 
        {
            transform.position = Vector2.MoveTowards(transform.position, mousePosition, movementSpeed*Time.deltaTime);
            isoRenderer.SetDirection(mousePosition);
        }
        if (!Input.GetMouseButton(0)) 
        {
            isoRenderer.SetDirection(new Vector2(0, 0));
        }
    }

    public void SetCanMove(bool move)
    {
        //Sets canMove for pauseMenu
        canMove = move;
    }
}
