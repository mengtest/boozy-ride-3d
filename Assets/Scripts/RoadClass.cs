using UnityEngine;
using System.Collections;

public class RoadClass : MonoBehaviour {
	
		public GameObject [] roadPieces = new GameObject[2];
	const float roadLength = 100f;

	const float roadSpeed = 50f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		foreach (GameObject road in roadPieces)
		{
			Vector3 newRoadPos = road.transform.position;
			newRoadPos.z -= roadSpeed * Time.deltaTime;
			if (newRoadPos.z < - roadLength / 2)
			{
				newRoadPos.z += roadLength;
			}

			road.transform.position = newRoadPos;
		}



	}
}
