using UnityEngine;
using System.Collections;

public class VehicleContainerClass : MonoBehaviour {

	private float speed = 5.0f;
	bool value = false; 


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Camera.main.transform.Translate (0, 0, speed * Time.deltaTime, Space.World);

		gameObject.transform.Translate (0, 0, speed * Time.deltaTime, Space.World);


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
			transform.Translate(new Vector3(1 * Time.deltaTime * 4, 0, 0));

		}
		else if (value == true)
		{
			transform.Translate(new Vector3(-1 * Time.deltaTime * 4, 0, 0));

		}

	}
}
