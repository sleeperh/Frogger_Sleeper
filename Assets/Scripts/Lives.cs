using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    public Dropdown dropDown;

    public static int lives;
    public void LivesMenu()
    {
        switch (dropDown.value)
        {
            case 1:
                PlayerPrefs.SetInt("Lives", 1);
                break;
            case 2:
                PlayerPrefs.SetInt("Lives", 2);
                break;
            case 3:
                PlayerPrefs.SetInt("Lives", 3);
                break;
            default:
                PlayerPrefs.SetInt("Lives", 3);
                break;
        }
    }
}
