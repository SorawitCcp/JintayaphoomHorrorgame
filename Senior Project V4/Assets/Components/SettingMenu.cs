using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void SetVolume (float volume)
    {

        audioMixer.SetFloat("volume", volume);
        
    }

    public void SetBGMVolume(float BGM)
    {

        audioMixer.SetFloat("BGM", BGM);

    }

    public void SetSFXVolume(float SFX)
    {

        audioMixer.SetFloat("SFX", SFX);

    }

    public void SetConVolume(float Con)
    {

        audioMixer.SetFloat("Con", Con);

    }

    public void SetUIVolume(float UI)
    {

        audioMixer.SetFloat("UI", UI);

    }

    public void SetQuality (int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

}
