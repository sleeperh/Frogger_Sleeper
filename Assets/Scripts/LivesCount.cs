using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesCount : MonoBehaviour
{
    public GameObject lifeOne;
    public GameObject lifeTwo;
    public GameObject lifeThree;
    
    private int lives;
    
    // Update is called once per frame
    void Update()
    {
        lives = PlayerPrefs.GetInt("Lives");
        if(lives == 3)
        {
            lifeOne.SetActive(true);
            lifeTwo.SetActive(true);
            lifeThree.SetActive(true);
        }
        else if (lives == 2)
        {
            lifeOne.SetActive(true);
            lifeTwo.SetActive(true);
            lifeThree.SetActive(false);
        }
        else if (lives == 1)
        {
            lifeOne.SetActive(true);
            lifeTwo.SetActive(false);
            lifeThree.SetActive(false);
        }
    }
}
