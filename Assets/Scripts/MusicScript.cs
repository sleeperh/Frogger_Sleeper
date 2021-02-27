using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicScript : MonoBehaviour
{
    [SerializeField]
    private AudioSource froggerMusic;
    [SerializeField]
    private Toggle toggle;
    
    public void Awake()
    {
        if(!PlayerPrefs.HasKey("Music"))
        {
            PlayerPrefs.SetInt("Music", 1);
            toggle.isOn = true;
            froggerMusic.enabled = true;
            PlayerPrefs.Save();
        }
        else
        {
            if (PlayerPrefs.GetInt("Music") == 0)
            {
                froggerMusic.enabled = false;
                toggle.isOn = false;
            }
            else
            {
                froggerMusic.enabled = true;
                toggle.isOn = true;
            }
        }
    }
    public void Update()
    {
        PlayerPrefs.GetInt("Music");

    }
}
