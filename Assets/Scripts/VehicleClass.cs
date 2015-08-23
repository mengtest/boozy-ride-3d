using UnityEngine;
using System.Collections;

public class VehicleClass : MonoBehaviour {

	int vehicleDirection = -1;
	float speed = 5.0f;

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

		//Move ();
	}

	void Move() {
		//transform.Translate (speed * Time.deltaTime * vehicleDirection, 0, 0);

		//Vector3 force = new Vector3 (vehicleDirection * 1000, 0, 0);
		//rb.AddForce (force);
	}

}
