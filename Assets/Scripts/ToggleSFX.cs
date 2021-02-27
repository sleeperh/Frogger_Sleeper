using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleSFX : MonoBehaviour
{
    public Toggle sfxToggle;
    public Toggle musicToggle;

    private void Start()
    {
        PlayerPrefs.SetInt("SFX", 1);
        PlayerPrefs.SetInt("Music", 1);
    }

    public void SFXToggle()
    {
        if (sfxToggle.isOn)
            PlayerPrefs.SetInt("SFX", 1);
        else
            PlayerPrefs.SetInt("SFX", 0);
    }
    public void MusicToggle()
    {
        if (musicToggle.isOn)
            PlayerPrefs.SetInt("Music", 1);
        else
            PlayerPrefs.SetInt("Music", 0);
    }
}
