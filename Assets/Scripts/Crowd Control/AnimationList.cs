using UnityEngine;
using System.Collections;

public class AnimationList 
{
    private static string[] animList = { "idle","celebration", "celebration2", "celebration3" };

    public static string randomAnimation()
    { 
    int randomAninNumber = Random.Range(0,4);
    return animList[randomAninNumber].ToString(); 

    }
}
