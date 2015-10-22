using UnityEngine;
using System.Collections;

public class RoadTileClass : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {        
        float distance = gameObject.transform.position.z + 100 - Camera.main.transform.position.z;

        if (distance <= 0)
        {
            Destroy(gameObject);
        }
        
    }

    void OnBecameInvisible()
    {
        //float distance = transform.position.z - GameObject.FindGameObjectWithTag("Player").transform.position.z;

        //if (distance <= 0.0f)
        //{
        //    Destroy(gameObject);
        //}
    }

}
