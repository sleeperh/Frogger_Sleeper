using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Goal : MonoBehaviour
{
    public GameObject goalPanel;
    public GameObject goalText;
    public GameObject continueBtn;
    public GameObject quitBtn;


    private void Start()
    {
        GoalMenu(false);
    }
    void OnTriggerEnter2D ()
    {
        Debug.Log("YOU WON!");
        GoalMenu(true);
        Score.CurrentScore += 100;
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GoalMenu(bool activeBool)
    {
        goalPanel.SetActive(activeBool);
        goalText.SetActive(activeBool);
        continueBtn.SetActive(activeBool);
        quitBtn.SetActive(activeBool);
    }

    public void ContinueBtn()
    {
        GoalMenu(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitBtn()
    {
        GoalMenu(false);
        SceneManager.LoadScene("GameOver");
    }    
}
