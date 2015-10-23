using UnityEngine;
using System.Collections;

public class GUIInGameClass : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject lifePanel;

    private bool isPaused = false;

    // Use this for initialization
    void Start()
    {
        pausePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

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
}
