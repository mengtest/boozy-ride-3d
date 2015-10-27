using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets.ImageEffects;

public class VehicleClass : MonoBehaviour
{

    float speed = 5.0f;

    bool value = false;
    bool isCollided = false;

    float timer = 10.0f;

    public Text distanceText;
    public Slider limeSlider;
    public GameObject pausePanel;
    public GameObject lifePanel;
    private GameObject collidedCar;

    public float distance;
    private int collectedLimes;
    private int missedLimes;

    public AudioSource coinSound;
    public AudioSource wallCollision;

    public float rotateSpeed = 80.0f;
    private float zeroSpeed = 0.0f;

    private Vector3 initAngle;
    private Vector3 initPosition;

    void Start()
    {
        collectedLimes = 0;
        missedLimes = 0;

        initAngle = gameObject.transform.eulerAngles;
        initPosition = gameObject.transform.position;

        PlayerPrefs.SetInt("availableHealth", 2);
    }

    void Update()
    {
        if (!(Time.timeScale == 0f))
        {
            distance += 0.01f;
            SetDistance();
            bool scorePassed = CheckScore((int)distance);

            if (scorePassed)
            {
                distanceText.color = Color.cyan;
            }
        }

        if (isCollided)
        {
            int remainingLifes = PlayerPrefs.GetInt("availableHealth", 0);

            if (remainingLifes > 0)
            {
                Time.timeScale = 0;                
                lifePanel.SetActive(true);
            }
            else
            {
                timer -= 1.0f;

                if (timer == 0.0f)
                {
                    Application.LoadLevel("GameOverScene");
                }
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
                
                if (transform.eulerAngles.y > 210.0)
                {
                    transform.Rotate(Vector3.up, zeroSpeed);
                }
                else
                {
                    transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                }

            }
            else if (value == true)
            {
                if (transform.eulerAngles.y < 150)
                {
                    transform.Rotate(-Vector3.up, zeroSpeed);
                    
                }
                else
                {
                    transform.Rotate(-Vector3.up, rotateSpeed * Time.deltaTime);
                }

            }
        }

        float xPos = gameObject.transform.position.x;

        if ((xPos < -12.0f) || (xPos > 12.0f))
        {
            if (!isCollided)
                wallCollision.Play();

            isCollided = true;
            
            SetScore();

            Application.LoadLevel("GameOverScene");
        }

        ActionForMissedLimes();

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Wall" || other.gameObject.tag == "CrossCar")
        {
            if (!isCollided)
                wallCollision.Play();

            isCollided = true;

            SetScore();
        }

        if (other.gameObject.tag == "CrossCar")
        {
            collidedCar = other.gameObject;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            Destroy(other.gameObject);
            coinSound.Play();

            collectedLimes++;

            if (missedLimes > 0)
            {
                missedLimes--;
            }
            else
            {
                missedLimes = 0;
            }            

            UpdateLimeCount();
        }
    }

    private void SetDistance()
    {
        distanceText.text = ((int)distance).ToString() + " m";
    }

    private void UpdateLimeCount()
    {
        limeSlider.value = collectedLimes;

        if (collectedLimes == 50)
        {
            int oldHealth = PlayerPrefs.GetInt("availableHealth", 0);

            PlayerPrefs.SetInt("availableHealth", oldHealth++);

            limeSlider.value = 0;
            collectedLimes = 0;
        }       
    
    }

    private bool CheckScore(int newScore)
    {
        int oldScore = PlayerPrefs.GetInt("highScore", 0);

        if (oldScore < newScore)
        {
            return true;
        }

        return false;
    }

    private void SetScore()
    {
        PlayerPrefs.SetInt("yourScore", (int)distance);

        if (CheckScore((int)distance))
        {
            PlayerPrefs.SetInt("highScore", (int)distance);
        }
    }

    void MissedLime()
    {
        if (missedLimes < 3)
        {
            missedLimes++;
        }
    }

    void ActionForMissedLimes()
    {
        if (missedLimes == 3)
        {
            var component = GameObject.Find("Main Camera").GetComponent<CameraMotionBlur>();
            component.enabled = true;
            component.maxVelocity = 10.0f;
        }

        if (missedLimes == 2)
        {
            var component = GameObject.Find("Main Camera").GetComponent<CameraMotionBlur>();
            component.enabled = true;
            component.maxVelocity = 7.0f;
        }

        if (missedLimes == 1)
        {
            var component = GameObject.Find("Main Camera").GetComponent<CameraMotionBlur>();
            component.enabled = true;
            component.maxVelocity = 3.0f;
        }

        if (missedLimes == 0)
        {
            var component = GameObject.Find("Main Camera").GetComponent<CameraMotionBlur>();
            component.enabled = false;
        }
    }
    
    void RestartGame()
    {
        isCollided = false;
        Time.timeScale = 1.0f;

        gameObject.transform.eulerAngles = initAngle;
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
                
        //Physics.IgnoreCollision(gameObject.GetComponent<Collider>(), collidedCar.gameObject.GetComponent<Collider>());
        //collidedCar.gameObject.GetComponent<Rigidbody>().isKinematic = true;

        Destroy(collidedCar);

        distance = PlayerPrefs.GetInt("yourScore", 0);
        lifePanel.SetActive(false);

    }
}

