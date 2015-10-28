using UnityEngine;
using System.Collections;

public class AudienceGang2Controller : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        DestroyGangObject(); 
	}

    void DestroyGangObject()
    {
        Vector3 playerPos = GameObject.FindGameObjectWithTag("Player").transform.position;
        Vector3 gangPos = gameObject.transform.position;

        if (playerPos.z > gangPos.z + 10.0f)
        {
            Destroy(gameObject);
        }
    }
}
