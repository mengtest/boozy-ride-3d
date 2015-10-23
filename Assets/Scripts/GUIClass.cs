using UnityEngine;
using System.Collections;

public class GUIClass : MonoBehaviour
{

    bool isPaused = false;

    public GameObject pausePanel;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame()
    {
        Application.LoadLevel("GameScene");
    }

    public void RestartGame()
    {
        Application.LoadLevel("GameScene");
    }
    
}
