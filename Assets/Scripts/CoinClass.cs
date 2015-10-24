using UnityEngine;
using System.Collections;

public class CoinClass : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {
        float playerPos = GameObject.FindGameObjectWithTag("Player").transform.position.z;
        float coinPos = gameObject.transform.position.z;

        if (playerPos > coinPos)
        {
            Destroy(gameObject);
        }
    }

}
