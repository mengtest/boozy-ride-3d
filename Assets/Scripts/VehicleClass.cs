using UnityEngine;
using System.Collections;

public class VehicleClass : MonoBehaviour {

	int vehicleDirection = -1;
	float speed = 5.0f;
    bool value = false; 


	Rigidbody rb;

	void Start () {
		rb = gameObject.GetComponent<Rigidbody> ();
	}

	void Update () {

		Camera.main.transform.Translate (0, 0, speed * Time.deltaTime, Space.World);

		gameObject.transform.Translate (0, 0, speed * Time.deltaTime, Space.World);

		Vector3 turnForce = new Vector3 (vehicleDirection * 1000, 0, 0);

		rb.AddForce (turnForce);

		if (Input.GetMouseButtonDown (0)) {
			vehicleDirection *= -1;
		}



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

            transform.Translate(new Vector3(1 * Time.deltaTime * 4, 0, 0), Space.Self);
            transform.Rotate(0, Time.deltaTime * -70, 0);



        }
        else if (value == true)
        {

            transform.Translate(new Vector3(-1 * Time.deltaTime * 4, 0, 0), Space.Self);
            transform.Rotate(0, Time.deltaTime * 70, 0);


        }


		//Move ();
	}

	void Move() {
		//transform.Translate (speed * Time.deltaTime * vehicleDirection, 0, 0);

		//Vector3 force = new Vector3 (vehicleDirection * 1000, 0, 0);
		//rb.AddForce (force);
	}

}
