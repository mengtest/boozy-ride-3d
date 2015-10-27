using UnityEngine;
using System.Collections;

public class GUIClass : MonoBehaviour
{
    void Start()
    {

    }

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
