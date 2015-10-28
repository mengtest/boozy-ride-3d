using UnityEngine;
using System.Collections;

public class HumanSpawner : MonoBehaviour {


    public GameObject leftHuman;
    public GameObject rightHuman; 

	// Use this for initialization
	void Start () {
        InvokeRepeating("GenerateHuman", 1.0f, 2.0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void GenerateHuman()
    {
        Vector3 playerPos = GameObject.FindGameObjectWithTag("Player").transform.position;
        float randomZ = UnityEngine.Random.Range(playerPos.z + 3.0f, playerPos.z + 10.0f); //Random position of the human along z axis 
        float randomSpawnStatus = Random.Range(-10,10); 

        //The Spawner wont spawn for every time interval 
        if(randomSpawnStatus >0 )
        {
            float randomSide = Random.Range(-10,10); 
            //Animate from Left to Right 
            if(randomSide >0 ) 
            {
                Vector3 spawnPosition = new Vector3(-3.4f, 0.0f, randomZ);
                Instantiate(leftHuman, spawnPosition, Quaternion.identity);
            }
                //Animate from Right to Left 
            else
            {
                Vector3 spawnPosition = new Vector3(3.4f, 0.0f, randomZ);
                Instantiate(rightHuman, spawnPosition, Quaternion.identity);
            }
        }
    }
}
