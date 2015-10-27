using UnityEngine;
using System.Collections;

public class CrossCarRightClass : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = GameObject.FindGameObjectWithTag("Player").transform.position;
        Vector3 jeepPos = gameObject.transform.position;

        if (Vector3.Distance(playerPos, jeepPos) < 15.0f)
        {
            gameObject.transform.Translate((-1) * new Vector3(Random.Range(4, 7) * Time.deltaTime, 0, 0), Space.World);
        }

        if (playerPos.z > jeepPos.z + 10.0f)
        {
            Destroy(gameObject);
        }
    }
}
