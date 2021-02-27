using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InputName : MonoBehaviour
{
    public InputField inputField;

    public void SaveName()
    {
        PlayerPrefs.SetString("Name", inputField.text);
        PlayerPrefs.Save();
    }


}
