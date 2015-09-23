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

        /*

        if (value == false)
        {
            transform.Rotate(0, Time.deltaTime * 30, 0);
        }
        else if (value == true)
        {
            transform.Rotate(0, Time.deltaTime * -30, 0);
        }

        */
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Wall")
        {            
            Application.LoadLevel("GameOverScene");
        }

        if (col.gameObject.tag == "Coin")
        {
            

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
