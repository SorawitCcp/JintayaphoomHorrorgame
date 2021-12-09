using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    float batteryLifeInSeconds = 45f;
    float maxIntensity = 2f;

    private float batteryLife;
    private float timer = 1f;
    private bool isActive;

    private Light playerFlashlight;

    public GameObject threeCell;
    public GameObject twoCell;
    public GameObject oneCell;
    public GameObject zeroCell;

    void Start()
    {
        playerFlashlight = GetComponent<Light>();
        batteryLife = timer;
    }

    void Update()
    {
        if (!GameComScript.gamePause)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                timer = 1;
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                isActive = !isActive;
            }
            if (isActive)
            {
                playerFlashlight.enabled = true;
                timer -= batteryLife / batteryLifeInSeconds * Time.deltaTime;
                if(timer <= 1 && timer > 0.65)
                {
                    playerFlashlight.intensity = maxIntensity;
                    threeCell.SetActive(true);
                    twoCell.SetActive(false);
                    oneCell.SetActive(false);
                    zeroCell.SetActive(false);
                } else if (timer <= 0.65 && timer > 0.33)
                {
                    threeCell.SetActive(false);
                    twoCell.SetActive(true);
                    oneCell.SetActive(false);
                    zeroCell.SetActive(false);
                } else if (timer <= 0.33 && timer > 0.01)
                {
                    threeCell.SetActive(false);
                    twoCell.SetActive(false);
                    oneCell.SetActive(true);
                    zeroCell.SetActive(false);
                } else
                {
                    threeCell.SetActive(false);
                    twoCell.SetActive(false);
                    oneCell.SetActive(false);
                    zeroCell.SetActive(true);
                    playerFlashlight.intensity = 0f;
                }
            } else
            {
                playerFlashlight.enabled = false;
            }
        }
    }

    public void AddBatteryLife()
    {
        timer = 1;
        if(playerFlashlight.intensity > maxIntensity)
        {
            playerFlashlight.intensity = maxIntensity;
        }
    }
}
