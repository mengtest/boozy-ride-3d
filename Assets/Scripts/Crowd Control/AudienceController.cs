using UnityEngine;
using System.Collections;

public class AudienceController : MonoBehaviour {

    private string animationName; 

	// Use this for initialization
	void Start () {
        animationName = AnimationList.randomAnimation(); 
	}
	
	// Update is called once per frame
	void Update () {
        animAudienceMember(); 
	}

    void animAudienceMember()
    {
        gameObject.GetComponent<Animation>().Play(animationName);
    }


}
