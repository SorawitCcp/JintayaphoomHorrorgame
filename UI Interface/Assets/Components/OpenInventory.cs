using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenInventory : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject Note;
    public GameObject PauseMenu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) || Input.GetKeyDown(KeyCode.Tab))
        {
            if (Canvas.active || Note.active)
            {
                Canvas.SetActive(false);
                Note.SetActive(false);
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
            }
        }
    }

}

