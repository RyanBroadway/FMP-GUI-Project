using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Villager_Viewer : MonoBehaviour
{
    int ViewVillager = 0;
    int ViewVillagerStor = 0;
    void Update()
    {
        ViewVillager = GameObject.Find("Resource_Holder").GetComponent<Resources>().Vilager;
        ViewVillagerStor = GameObject.Find("Resource_Holder").GetComponent<Resources>().Villager_Huts;
        GetComponent<TextMeshProUGUI>().text = ViewVillager.ToString() + "/" + ViewVillagerStor.ToString();
        if (ViewVillagerStor > 999)
        {
            GetComponent<TextMeshProUGUI>().fontSize = 12;
        }
    }
}
