using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Wood_Viewer : MonoBehaviour
{
    int ViewWood = 0;
    int ViewWoodStor = 0;
    void Update()
    {
        ViewWood = GameObject.Find("Resource_Holder").GetComponent<Resources>().Wood;
        ViewWoodStor = GameObject.Find("Resource_Holder").GetComponent<Resources>().Wood_Storage;
        GetComponent<TextMeshProUGUI>().text = ViewWood.ToString() + "/" + ViewWoodStor.ToString();
        if (ViewWoodStor > 99999)
        {
            GetComponent<TextMeshProUGUI>().fontSize = 12;
        }
    }
}
