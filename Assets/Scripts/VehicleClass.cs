using UnityEngine;
using System.Collections;

public class VehicleClass : MonoBehaviour {

	int x = 100;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.Rotate(0, Input.GetAxis("Horizontal")*-x*Time.deltaTime, 0);
	}
}
