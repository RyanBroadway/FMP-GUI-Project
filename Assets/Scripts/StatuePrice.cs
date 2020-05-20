using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StatuePrice : MonoBehaviour
{
    public string type = " ";
    int StatueProgress = 1;
    int basicresource = 1000;
    int villagersource = 10;
    void Update()
    {
        if (type == "Normal")
        {
            StatueProgress = GameObject.Find("Resource_Holder").GetComponent<Resources>().Statprog;
            basicresource = Convert.ToInt32(basicresource * (5 * (StatueProgress + 1)));
            GetComponent<TextMeshProUGUI>().text = basicresource.ToString();
        }
        if (type == "Village")
        {
            StatueProgress = GameObject.Find("Resource_Holder").GetComponent<Resources>().Statprog;
            villagersource = Convert.ToInt32(villagersource * (5 * (StatueProgress + 1)));
            GetComponent<TextMeshProUGUI>().text = villagersource.ToString();
        }
        basicresource = 1000;
        villagersource = 10;
    }
}
