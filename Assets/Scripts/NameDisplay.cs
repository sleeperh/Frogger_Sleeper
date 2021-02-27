using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NameDisplay : MonoBehaviour
{
    public Text nameText;

    private void Start()
    {
        if(PlayerPrefs.GetString("Name") == "")
        {
            PlayerPrefs.SetString("Name", "No Name");
        }
        nameText.text = PlayerPrefs.GetString("Name");
    }
}
