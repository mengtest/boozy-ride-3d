using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class VehicleClass : MonoBehaviour
{

    float speed = 5.0f;
    int timer = 20;
    bool value = false;

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

        if (Input.GetMouseButtonDown(0) && value == false)
        {
            value = true;
        }
        else if (Input.GetMouseButtonDown(0) && value == true)
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

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Wall")
        {
            wallCollision.Play();
            Application.LoadLevel("GameOverScene");
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
}
