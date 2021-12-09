using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenPauseMenu : MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject Inventory;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (PauseMenu.active )
            {
                PauseMenu.SetActive(false);
                ContinueGame();
            }
            else if(PauseMenu.active == false)
            {
                if(Inventory.active == false)
                {
                    PauseMenu.SetActive(true);
                    PauseGame();
                }
            }
        }
    }

    private void PauseGame()
    {
        Time.timeScale = 0;
        PauseMenu.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    private void ContinueGame()
    {
        Time.timeScale = 1;
        PauseMenu.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

}