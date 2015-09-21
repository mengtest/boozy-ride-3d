using UnityEngine;
using System.Collections;
using System;

public class GenerateRoadTileClass : MonoBehaviour
{

    private float distance = 15.0f;
    public GameObject[] roadTiles;

    // Use this for initialization
    void Start()
    {
        //InvokeRepeating ("CreateRoad",1.0f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        float camPos = Camera.main.transform.position.z;

        float d = Math.Abs(distance - camPos);

        if (d > 0.0f)
        {
            CreateRoad();
            //CreateRoad();
        }
    }

    void CreateRoad()
    {
        distance += 15.0f;

        float random = UnityEngine.Random.Range(0, roadTiles.Length);

        int selectedIndex = (int)random;

        GameObject selectedGameObject = roadTiles[selectedIndex];

        Vector3 spawnPosition = new Vector3(0, 0, distance);

        Instantiate(selectedGameObject, spawnPosition, selectedGameObject.transform.rotation);

    }
}
