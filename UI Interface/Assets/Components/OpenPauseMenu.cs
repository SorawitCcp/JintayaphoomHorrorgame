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
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PauseMenu.active )
            {
                PauseMenu.SetActive(false);
            }
            else if(PauseMenu.active == false)
            {
                if(Inventory.active == false)
                {
                    PauseMenu.SetActive(true);
                }
            }
        }
    }

}