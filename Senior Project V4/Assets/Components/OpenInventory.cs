using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenInventory : MonoBehaviour
{
    public GameObject Inventory;
    public GameObject Note;
    public GameObject PauseMenu;

    void Start()
    {
        Inventory.SetActive(false);
        Note.SetActive(false);
    }
    void Update()
    {
        if (!GameComScript.gamePause)
        {
            if (Input.GetKeyDown(KeyCode.I) || Input.GetKeyDown(KeyCode.Tab))
            {
                if (Inventory.active || Note.active)
                {
                    Inventory.SetActive(false);
                    Note.SetActive(false);
                    GameObject.Find("FPSCamera").GetComponent<MouseLook>().enabled = true;
                    Cursor.visible = false;
                    Cursor.lockState = CursorLockMode.Locked;
                }
                else if(PauseMenu.active == false && Inventory.active == false)
                {
                    Inventory.SetActive(true);
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                    GameObject.Find("FPSCamera").GetComponent<MouseLook>().enabled = false;
                }
            }
            else if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (Note.active)
                {
                    Note.SetActive(false);
                }
                else
                {
                    Inventory.SetActive(false);
                    GameObject.Find("FPSCamera").GetComponent<MouseLook>().enabled = true;
                    Cursor.visible = false;
                    Cursor.lockState = CursorLockMode.Locked;
                }
            }
        }
    }
}

