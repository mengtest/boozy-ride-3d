using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayScoreClass : MonoBehaviour {

    public Text yourScoreText;
    public Text highScoreText;

	// Use this for initialization
	void Start () {

        yourScoreText.text = PlayerPrefs.GetInt("yourScore").ToString();
        highScoreText.text = PlayerPrefs.GetInt("highScore", 0).ToString();        

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
