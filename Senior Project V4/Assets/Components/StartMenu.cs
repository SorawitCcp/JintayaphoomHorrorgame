using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public GameObject Canvas;
    void Update()
    {
        if (Input.anyKey)
        {
            Canvas.SetActive(true);
        }
    }

}
