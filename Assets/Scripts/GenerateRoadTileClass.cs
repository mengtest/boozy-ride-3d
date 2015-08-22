using UnityEngine;
using System.Collections;

public class GenerateRoadTileClass : MonoBehaviour {

	private float distance = 15.0f;
	public GameObject roadTiles;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("CreateRoad", 0f, 2.0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void CreateRoad(){
		distance += 15.0f;

		Vector3 spawnPosition = new Vector3(0,0, distance);
		Instantiate (roadTiles, spawnPosition, roadTiles.transform.rotation);

	}
}
