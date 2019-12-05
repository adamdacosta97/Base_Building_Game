using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheatCodes : MonoBehaviour
{
    //Checks to see if a cheat key is pressed and activates the cheat
    void Update()
    {
        if(Input.GetKeyDown("c"))
        {
            PlayerStats.Money += 100;
        }
        if(Input.GetKeyDown("l"))
        {
            GaveOver.lives = 900;
        }
    }
}
