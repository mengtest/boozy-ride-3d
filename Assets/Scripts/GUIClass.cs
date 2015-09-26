using UnityEngine;
using System.Collections;

public class GUIClass : MonoBehaviour {

    bool isPaused = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void StartGame()
    {
        Application.LoadLevel("GameScene");
    }

    public void RestartGame()
    {
        Application.LoadLevel("GameScene");
    }

    public void PauseOrResume()
    {
        togglePause();
    }

    bool togglePause()
    {
        if (Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
            return (false);
        }
        else
        {
            Time.timeScale = 0f;
            return (true);
        }
    }
}
