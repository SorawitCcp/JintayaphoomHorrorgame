using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameComScript : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject PauseMenu;
    public static bool gamePause;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PauseMenu.active)
        {
            gamePause = !gamePause;
        }
    }
}
