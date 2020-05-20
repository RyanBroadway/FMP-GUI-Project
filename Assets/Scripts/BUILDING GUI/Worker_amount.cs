using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Worker_amount : MonoBehaviour
{
    public string BuildingType = " ";
    int Worker = 0;
    int Building = 0;
    void Update()
    {
        if (BuildingType == "Lumber")
        {
            Worker = GameObject.Find("Resource_Holder").GetComponent<Resources>().Wood_Worker;
            Building = GameObject.Find("Resource_Holder").GetComponent<Resources>().Lumber_Mills;
            GetComponent<TextMeshProUGUI>().text = Worker.ToString() + "/" + Building.ToString();
            if (Building > 999)
            {
                GetComponent<TextMeshProUGUI>().fontSize = 20;
            }
        }
        if (BuildingType == "Stone")
        {
            Worker = GameObject.Find("Resource_Holder").GetComponent<Resources>().Stone_Worker;
            Building = GameObject.Find("Resource_Holder").GetComponent<Resources>().Mines;
            GetComponent<TextMeshProUGUI>().text = Worker.ToString() + "/" + Building.ToString();
            if (Building > 999)
            {
                GetComponent<TextMeshProUGUI>().fontSize = 20;
            }
        }
        if (BuildingType == "Wheat")
        {
            Worker = GameObject.Find("Resource_Holder").GetComponent<Resources>().Wheat_Worker;
            Building = GameObject.Find("Resource_Holder").GetComponent<Resources>().Fields;
            GetComponent<TextMeshProUGUI>().text = Worker.ToString() + "/" + Building.ToString();
            if (Building > 999)
            {
                GetComponent<TextMeshProUGUI>().fontSize = 20;
            }
        }
    }
}
