using UnityEngine;
using System.Collections;

public class VehicleContainerClass : MonoBehaviour
{
    private float speed = 5.0f;
    bool value = false;

    void Start()
    {

    }

    void Update()
    {

        Camera.main.transform.Translate(0, 0, speed * Time.deltaTime, Space.World);

        gameObject.transform.Translate(0, 0, speed * Time.deltaTime, Space.World);

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            value = !value;
        }

        if (value)
        {
            transform.Translate(new Vector3(-1 * Time.deltaTime * 4, 0, 0));
        }
        else
        {
            transform.Translate(new Vector3(1 * Time.deltaTime * 4, 0, 0));
        }

    }
}
