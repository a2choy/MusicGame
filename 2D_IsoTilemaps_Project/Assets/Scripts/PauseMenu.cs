using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] IsometricPlayerMovementController playerMove;
    [SerializeField] GameObject player;

    private void Start()
    {
        playerMove = player.GetComponent<IsometricPlayerMovementController>();
    }

    public void SetPauseMenu()
    {
        //Turns pause menu on and off
        pauseMenu.SetActive(!pauseMenu.activeSelf);

        //Turns off ability for player to move if pause menu is on
        playerMove.SetCanMove(!pauseMenu.activeSelf);
    }
}
