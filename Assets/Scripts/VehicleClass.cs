using UnityEngine;
using System.Collections;

public class VehicleClass : MonoBehaviour {

	float speed = 5.0f;
    bool value = false; 


	void Start () {

	}

	void Update () {

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

	void OnCollisionEnter(Collision col){
		if (!(col.gameObject.tag == "Road")) {
			print ("collided");

			Time.timeScale = 0;
		}
	}
}
