using UnityEngine;
using System.Collections;

public class CoinClass : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        float playerPos = GameObject.FindGameObjectWithTag("Player").transform.position.z;
        float coinPos = gameObject.transform.position.z;

        if (playerPos > coinPos)
        {
            Destroy(gameObject);
        }
	}
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }

}
