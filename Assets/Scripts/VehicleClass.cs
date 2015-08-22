using UnityEngine;
using System.Collections;

public class VehicleClass : MonoBehaviour {

	int vehicleDirection = -1;
	float speed = 10.0f;

	Rigidbody rb;

	void Start () {
		rb = gameObject.GetComponent<Rigidbody> ();
	}

	void Update () {

		gameObject.transform.Translate (Vector3.forward);

		if (Input.GetMouseButtonDown (0)) {
			vehicleDirection *= -1;
		}

		Move ();
	}

	void Move() {
		//transform.Translate (speed * Time.deltaTime * vehicleDirection, 0, 0);

		Vector3 force = new Vector3 (vehicleDirection * 1000, 0, 0);
		rb.AddForce (force);
	}

}
