using UnityEngine;
using System.Collections;

public class AnimationList 
{
    private static string[] animList = { "applause", "applause2", "celebration", "celebration2", "celebration3" };

    public static string randomAnimation()
    { 
    int randomAninNumber = Random.Range(0,4);
    return animList[randomAninNumber].ToString(); 

    }
}
