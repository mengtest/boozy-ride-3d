using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class VehicleClass : MonoBehaviour
{

    float speed = 5.0f;

    bool value = false;
    bool isCollided = false;

    float timer = 10.0f;

    public Text distanceText;
    public Text coinText;

    private float distance;
    private int collectedCoins;

    public AudioSource coinSound;
    public AudioSource wallCollision;

    void Start()
    {
        distance = 0;
        collectedCoins = 0;
    }

    void Update()
    {
        distance += 0.1f;
        UpdateDistance();
        CheckScore((int)distance);

        if (isCollided)
        {
            timer -= 1.0f;

            if (timer == 0.0f)
            {
                Application.LoadLevel("GameOverScene");
            }
        }
        else
        {
            if ((Input.GetMouseButtonDown(0) && value == false) || Input.touchCount == 1)
            {
                value = true;
            }
            else if ((Input.GetMouseButtonDown(0) && value == true) || Input.touchCount == 1)
            {
                value = false;
            }

            if (value == false)
            {
                transform.Rotate(0, Time.deltaTime * 30, 0);
            }
            else if (value == true)
            {
                transform.Rotate(0, Time.deltaTime * -30, 0);
            }
        }

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Wall" || other.gameObject.tag == "CrossCar")
        {
            isCollided = true;
            wallCollision.Play();

            print("Score: " + ((int)distance) + " High Score : " + PlayerPrefs.GetInt("highScore"));
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            Destroy(other.gameObject);
            coinSound.Play();
            collectedCoins++;
            UpdateCoinCount();
        }
    }

    void UpdateDistance()
    {
        distanceText.text = ((int)distance).ToString();
    }

    void UpdateCoinCount()
    {
        coinText.text = collectedCoins.ToString();
    }

    void CheckScore(int newScore)
    {
        int oldScore = PlayerPrefs.GetInt("highScore", 0);

        if (oldScore < newScore)
        {
            PlayerPrefs.SetInt("highScore", newScore);
            print("High Score updated: " + newScore);
        }
    }
}
