using UnityEngine;
using System.Collections;

public class GenerateRoadTileClass : MonoBehaviour {

	private float distance = 15.0f;
	public GameObject [] roadTiles;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("CreateRoad", 1.0f, 2.0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void CreateRoad(){

		distance += 15.0f;

		float random = Random.Range (0, roadTiles.Length);

		print (random);

		int selectedIndex = (int)random;

		GameObject selectedGameObject = roadTiles [selectedIndex];

		Vector3 spawnPosition = new Vector3(0, 0, distance);
		Instantiate (selectedGameObject, spawnPosition, selectedGameObject.transform.rotation);

	}
}
