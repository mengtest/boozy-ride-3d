using UnityEngine;
using System.Collections;
using System;

public class GenerateRoadTileClass : MonoBehaviour
{

    private float distance = 30.0f;

    public GameObject[] roadTiles;
    public GameObject lime;

    void Start()
    {
        InvokeRepeating("CreateRoad", 1.0f, 2.0f);
        InvokeRepeating("CreateCoin", 1.0f, 2.0f);
    }

    void Update()
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
        float randomZ = UnityEngine.Random.Range(distance, distance + 10.0f);
        float randomX = UnityEngine.Random.Range(-2.0f, 2.0f);

        Vector3 spawnPosition = new Vector3(randomX, 0.5f, randomZ);

        Instantiate(lime, spawnPosition, Quaternion.identity);

    }
}
