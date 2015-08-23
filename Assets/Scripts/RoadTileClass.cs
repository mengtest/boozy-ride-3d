using UnityEngine;
using System.Collections;

public class RoadTileClass : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void Update(){
		//if (Vector3. (Camera.main.transform.position, transform.position) > 100.0f) {
			//Destroy(gameObject);
		//}

		float distance = gameObject.transform.position.z + 100 - Camera.main.transform.position.z;

		if (distance <= 0) {
			Destroy(gameObject);
		}
	}

}
