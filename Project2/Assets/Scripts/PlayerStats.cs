using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    //records player health, and money
    public static int Money;
    public int startMoney = 400;

    void Start()
    {
        Money = startMoney;
    }
}
