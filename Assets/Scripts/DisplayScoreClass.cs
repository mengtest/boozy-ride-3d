using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayScoreClass : MonoBehaviour
{
    public Text yourScoreText;
    public Text highScoreText;

    void Start()
    {

        yourScoreText.text = PlayerPrefs.GetInt("yourScore").ToString() + " m";
        highScoreText.text = PlayerPrefs.GetInt("highScore", 0).ToString() + " m";
    }

    void Update()
    {

    }
}
