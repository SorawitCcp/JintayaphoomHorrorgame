using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{

    public GameObject cameraOne;
    public GameObject cameraTwo;
    public GameObject cameraThree;

    AudioListener cameraOneAudioLis;
    AudioListener cameraTwoAudioLis;
    AudioListener cameraThreeAudioLis;

    int MUp = 0;
    // Use this for initialization
    void Start()
    {

        //Get Camera Listeners
        cameraOneAudioLis = cameraOne.GetComponent<AudioListener>();
        cameraTwoAudioLis = cameraTwo.GetComponent<AudioListener>();
        cameraThreeAudioLis = cameraThree.GetComponent<AudioListener>();

        //Camera Position Set
        cameraPositionChange(PlayerPrefs.GetInt("CameraPosition"));
    }

    // Update is called once per frame
    void Update()
    {
        //Change Camera Keyboard
        switchCamera();

    }

    //UI JoyStick Method
    public void cameraPositonM()
    {
        cameraChangeCounter();
    }

    //Change Camera Keyboard
    void switchCamera()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            cameraChangeCounter();
        }
        else if (Input.GetMouseButtonDown(1))
        {
            cameraTwo.SetActive(false);
            cameraTwoAudioLis.enabled = false;

            cameraThree.SetActive(true);
            cameraThreeAudioLis.enabled = true;

            cameraOneAudioLis.enabled = false;
            cameraOne.SetActive(false);
            
        }

        else if (Input.GetMouseButtonUp(1))
        {
            MUp = 1;
            cameraChangeCounter();
        }

    }

    //Camera Counter
    void cameraChangeCounter()
    {
        int cameraPositionCounter = PlayerPrefs.GetInt("CameraPosition");
        if(MUp == 0)
        {
            cameraPositionCounter++;
        }
        MUp = 0;
        cameraPositionChange(cameraPositionCounter);
    }

    void ShoulderView()
    {
        int cameraPositionCounter = PlayerPrefs.GetInt("CameraPosition");
        cameraPositionCounter = 2;
        cameraPositionChange(cameraPositionCounter);
    }

    //Camera change Logic
    void cameraPositionChange(int camPosition)
    {

        if (camPosition > 1)
        {
            camPosition = 0;
        }

        //Set camera position database
        PlayerPrefs.SetInt("CameraPosition", camPosition);

        //Set camera position 1
        if (camPosition == 0)
        {
            cameraOne.SetActive(true);
            cameraOneAudioLis.enabled = true;

            cameraTwoAudioLis.enabled = false;
            cameraTwo.SetActive(false);

            cameraThreeAudioLis.enabled = false;
            cameraThree.SetActive(false);
        }

        //Set camera position 2
        if (camPosition == 1)
        {
            cameraTwo.SetActive(true);
            cameraTwoAudioLis.enabled = true;
            
            cameraThree.SetActive(false);
            cameraThreeAudioLis.enabled = false;

            cameraOneAudioLis.enabled = false;
            cameraOne.SetActive(false);
           
        }
        
        //Set camera position 3
        /*if (camPosition == 2)
        {
            cameraTwo.SetActive(false);
            cameraTwoAudioLis.enabled = false;
            
            cameraThree.SetActive(true);
            cameraThreeAudioLis.enabled = true;

            cameraOneAudioLis.enabled = false;
            cameraOne.SetActive(false);

        }*/

    }
}