using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenInventory : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject Note;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I)|| Input.GetKeyDown(KeyCode.Tab))
        {
            if (Canvas.active || Note.active)
            {
                Canvas.SetActive(false);
                Note.SetActive(false);
            }
            else
            {
                Canvas.SetActive(true);
            }
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Canvas.active || Note.active)
            {
                Canvas.SetActive(false);
                Note.SetActive(false);
            }
        }
    }

}

