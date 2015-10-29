using UnityEngine;
using System.Collections;

public class AudienceGangSpawnerController : MonoBehaviour {

    public GameObject leftGang;
    public GameObject rightGang; 

	// Use this for initialization
	void Start () {
        InvokeRepeating("GenerateAudience", 4.0f, 5.0f);
	}
	
	// Update is called once per frame
	void Update () {
        
        
	}

    void GenerateAudience()
    {
        Vector3 playerPos = GameObject.FindGameObjectWithTag("Player").transform.position;
        float randomZ = UnityEngine.Random.Range(playerPos.z + 20.0f, playerPos.z + 30.0f); //Random position of the audience along z axis 
        float randomSpawnStatus = Random.Range(-10, 10);

        //The Spawner wont spawn for every time interval 
        if (randomSpawnStatus > 0)
        {
            float randomSide = Random.Range(-10, 10);
            //Left Only
            if (randomSide > 0)
            {
                Vector3 spawnPosition = new Vector3(0.4f, 0.0f, randomZ);
                Instantiate(leftGang, spawnPosition, Quaternion.identity);
            }
            else if (randomSide == 0)
            {
                Vector3 spawnPosition1 = new Vector3(-0.4f, 0.0f, randomZ);
                Instantiate(leftGang, spawnPosition1, Quaternion.identity);

                Vector3 spawnPosition2 = new Vector3(0.4f, 0.0f, randomZ);
                Instantiate(rightGang, spawnPosition2, Quaternion.identity);
            }
            //Right Only 
            else
            {
                Vector3 spawnPosition = new Vector3(-0.4f, 0.0f, randomZ);
                Instantiate(rightGang, spawnPosition, Quaternion.identity);
            }
            
        }
    }
}
