using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Maximum : MonoBehaviour
{
    public string BuildingType = " ";
    int Price = 0;
    void Update()
    {
        if (BuildingType == "Lumber")
        {
            Price = GameObject.Find("Resource_Holder").GetComponent<Resources>().Wood_Storage;
            Price = Convert.ToInt32(Price * 0.8);
            GetComponent<TextMeshProUGUI>().text = Price.ToString();
            if (Price > 99999)
            {
                GetComponent<TextMeshProUGUI>().fontSize = 21;
            }
        }
        if (BuildingType == "Stone")
        {
            Price = GameObject.Find("Resource_Holder").GetComponent<Resources>().Stone_Storage;
            Price = Convert.ToInt32(Price * 0.8);
            GetComponent<TextMeshProUGUI>().text = Price.ToString();
            if (Price > 99999)
            {
                GetComponent<TextMeshProUGUI>().fontSize = 21;
            }
        }
        if (BuildingType == "Wheat")
        {
            Price = GameObject.Find("Resource_Holder").GetComponent<Resources>().Wheat_Storage;
            Price = Convert.ToInt32(Price * 0.8);
            GetComponent<TextMeshProUGUI>().text = Price.ToString();
            if (Price > 99999)
            {
                GetComponent<TextMeshProUGUI>().fontSize = 21;
            }
        }
    }
}
