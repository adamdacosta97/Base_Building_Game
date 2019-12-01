using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyUI : MonoBehaviour
{
    public Text moneyText;

    //Set the money in the UI to the plaery money
    void Update()
    {
        moneyText.text = PlayerStats.Money.ToString();
    }
}
