using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static float speed;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    private void Update()
    {
        speed = Menu.speed;
    }
}
