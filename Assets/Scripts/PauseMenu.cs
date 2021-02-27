using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    
    public GameObject pausePanel;
    public GameObject pauseText;
    public GameObject newGameBtn;
    public GameObject saveBtn;
    public GameObject loadBtn;
    public GameObject jsonBtn;
    public GameObject musicToggle;
    bool pause = false;
    
    private void Start()
    {
        PauseMenuUI(false); // initially false
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(!pause)
            {
                PauseMenuUI(true);
                pause = true;
            }
            else if (pause)
            {
                PauseMenuUI(false);
                pause = false;
            }
        }
    }

    public void PauseMenuUI(bool activeBool)
    {
        
        pausePanel.SetActive(activeBool);
        pauseText.SetActive(activeBool);
        newGameBtn.SetActive(activeBool);
        saveBtn.SetActive(activeBool);
        loadBtn.SetActive(activeBool);
        jsonBtn.SetActive(activeBool);
        musicToggle.SetActive(activeBool);
        if (activeBool)
        {
            Time.timeScale = 0;
        }
        else
            Time.timeScale = 1;
    }



    
}
