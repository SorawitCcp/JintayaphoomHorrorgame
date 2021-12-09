using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenPauseMenu : MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject Inventory;

    void Start()
    {
        Inventory.SetActive(false);
        PauseMenu.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (PauseMenu.active)
            {
                PauseMenu.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                GameObject.Find("FPSCamera").GetComponent<MouseLook>().enabled = true;
                Time.timeScale = 1;
            } else if(PauseMenu.active == false)
            {
                if(Inventory.active == false)
                {
                    PauseMenu.SetActive(true);
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                    GameObject.Find("FPSCamera").GetComponent<MouseLook>().enabled = false;
                    Time.timeScale = 0;
                }
            }
        }        
    }
}