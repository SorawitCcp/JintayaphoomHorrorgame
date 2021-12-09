using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenInventory : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject Note;
    public GameObject PauseMenu;

    void Start()
    {
        Canvas.SetActive(false);
        Note.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) || Input.GetKeyDown(KeyCode.Tab))
        {
            GameObject.Find("FPSCamera").GetComponent<MouseLook>().enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            if (Canvas.active || Note.active)
            {
                Canvas.SetActive(false);
                Note.SetActive(false);
                GameObject.Find("FPSCamera").GetComponent<MouseLook>().enabled = true;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
            else if(PauseMenu.active == false && Canvas.active == false)
            {
                Canvas.SetActive(true);
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
                Canvas.SetActive(false);
                GameObject.Find("FPSCamera").GetComponent<MouseLook>().enabled = true;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
        if(!Canvas.active)
        {
            GameObject.Find("FPSCamera").GetComponent<MouseLook>().enabled = true;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}

