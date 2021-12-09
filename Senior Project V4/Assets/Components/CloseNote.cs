using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CloseNote : MonoBehaviour
{
    public GameObject Canvas;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
                Canvas.SetActive(false);
        }
    }

}
