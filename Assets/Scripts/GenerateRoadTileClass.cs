using UnityEngine;
using System.Collections;
using System;

public class GenerateRoadTileClass : MonoBehaviour
{

    private float distance = 30.0f;
    public GameObject[] roadTiles;
    public GameObject coin;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("CreateRoad", 1.0f, 2.0f);
        InvokeRepeating("CreateCoin", 1.0f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {

    }

    void CreateRoad()
    {
        distance += 15.0f;
        float randomO = UnityEngine.Random.Range(0, roadTiles.Length);
        int selectedIndex = (int)randomO;
        GameObject selectedGameObject = roadTiles[selectedIndex];
        Vector3 spawnPosition = new Vector3(0, 0, distance);
        Instantiate(selectedGameObject, spawnPosition, selectedGameObject.transform.rotation);
    }

    void CreateCoin()
    {
        float randomZ = UnityEngine.Random.Range(distance, distance + 15.0f);
        float randomX = UnityEngine.Random.Range(-2.0f, 2.0f);
        Vector3 spawnPosition1 = new Vector3(randomX, 0.5f, randomZ);
        Vector3 spawnPosition2 = new Vector3(randomX, 0.5f, randomZ += 2.0f);
        Vector3 spawnPosition3 = new Vector3(randomX, 0.5f, randomZ += 2.0f);
        Instantiate(coin, spawnPosition1, coin.transform.rotation);
        Instantiate(coin, spawnPosition2, coin.transform.rotation);
        Instantiate(coin, spawnPosition3, coin.transform.rotation);
    }
}
