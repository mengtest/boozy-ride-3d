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

    private int distance;
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
        distance++;
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


            Application.LoadLevel("GameOverScene");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            coinSound.Play();

            collectedCoins++;
            UpdateCoinCount();
            
        }
    }

    void UpdateDistance()
    {
        distanceText.text = distance.ToString();
    }

    void UpdateCoinCount()
    {
        coinText.text = collectedCoins.ToString();
    }
}
