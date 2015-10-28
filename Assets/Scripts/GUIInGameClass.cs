using UnityEngine;
using System.Collections;

public class GUIInGameClass : MonoBehaviour
{
    public GameObject pausePanel;

    private bool isPaused = false;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseOrResume();
        }
    }

    public void PauseOrResume()
    {
        isPaused = togglePause();
        pausePanel.SetActive(isPaused);
    }

    bool togglePause()
    {
        if (Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
            return false;
        }
        else
        {
            Time.timeScale = 0f;
            return true;
        }
    }

    public void RestartGame()
    {
        GameObject.FindGameObjectWithTag("PlayerObject").SendMessage("RestartGame");
    }

    public void EndGame()
    {
        GameObject.FindGameObjectWithTag("PlayerObject").SendMessage("EndGame");
    }
}
