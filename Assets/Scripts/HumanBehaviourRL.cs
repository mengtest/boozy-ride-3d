using UnityEngine;
using System.Collections;

public class HumanBehaviourRL : MonoBehaviour {

    private bool isHumanCollided = false; 
	// Use this for initialization
	void Start () {
        gameObject.transform.Rotate(Vector3.up, -90f, Space.World); 
	}
	
	// Update is called once per frame
	void Update () {
        if (!isHumanCollided)
        {
            walkRightToLeft();
        }
            //if collided , what happens to the gameobject 
        else
        {
            gameObject.transform.Translate(new Vector3(Random.Range(1, 3) * Time.deltaTime, 0, 0), Space.World);
        }

        DestroyHumanObject();
	}

    void walkRightToLeft()
    {
        gameObject.GetComponent<Animation>().Play("walk");
        gameObject.transform.Translate(new Vector3(-Random.Range(1, 3) * Time.deltaTime, 0, 0), Space.World);
    }

    void DestroyHumanObject()
    {
        Vector3 playerPos = GameObject.FindGameObjectWithTag("Player").transform.position;
        Vector3 humanPos = gameObject.transform.position;

        if (playerPos.z > humanPos.z + 10.0f)
        {
            Destroy(gameObject);
        }
    }



    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlayerObject")
        {
            isHumanCollided = true;
            gameObject.GetComponent<Animation>().Play("death");
            //  Destroy(gameObject);
        }
    }
}
