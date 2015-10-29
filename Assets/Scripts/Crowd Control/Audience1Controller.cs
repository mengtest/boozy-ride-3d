using UnityEngine;
using System.Collections;

public class Audience1Controller : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        animAudienceMember(); 
	}

    void animAudienceMember()
    {
        gameObject.GetComponent<Animation>().Play(AnimationList.randomAnimation());
    }
}
