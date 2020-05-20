using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Wheat_Viewer : MonoBehaviour
{
    int ViewWheat = 0;
    int ViewWheatStor = 0;
    void Update()
    {
        ViewWheat = GameObject.Find("Resource_Holder").GetComponent<Resources>().Wheat;
        ViewWheatStor = GameObject.Find("Resource_Holder").GetComponent<Resources>().Wheat_Storage;
        GetComponent<TextMeshProUGUI>().text = ViewWheat.ToString() + "/" + ViewWheatStor.ToString();
        if (ViewWheatStor > 99999)
        {
            GetComponent<TextMeshProUGUI>().fontSize = 12;
        }
    }
}