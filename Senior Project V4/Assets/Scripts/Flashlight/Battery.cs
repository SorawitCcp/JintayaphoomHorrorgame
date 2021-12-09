using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Battery : MonoBehaviour
{
    bool enter;

    public void Update()
    {
        if (!GameComScript.gamePause)
        {
            if (Input.GetKeyDown(KeyCode.E) && enter)
            {
                GameObject.FindGameObjectWithTag("Flashlight").GetComponent<Flashlight>().AddBatteryLife();
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            enter = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            enter = false;
        }
    }
}
