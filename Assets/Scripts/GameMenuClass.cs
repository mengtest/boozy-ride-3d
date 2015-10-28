using UnityEngine;
using System.Collections;

public class GameMenuClass : MonoBehaviour
{
    public GameObject howToPanel;

    bool isVisible = false;

    void Start()
    {

    }

    void Update()
    {

    }

    public void Toggle()
    {
        isVisible = !isVisible;
        howToPanel.SetActive(isVisible);
    }
   
}
