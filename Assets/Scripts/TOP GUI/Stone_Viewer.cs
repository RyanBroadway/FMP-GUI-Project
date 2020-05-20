using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Stone_Viewer : MonoBehaviour
{
    int ViewStone = 0;
    int ViewStoneStor = 0;
    void Update()
    {
        ViewStone = GameObject.Find("Resource_Holder").GetComponent<Resources>().Stone;
        ViewStoneStor = GameObject.Find("Resource_Holder").GetComponent<Resources>().Stone_Storage;
        GetComponent<TextMeshProUGUI>().text = ViewStone.ToString() + "/" + ViewStoneStor.ToString();
        if (ViewStoneStor > 99999)
        {
            GetComponent<TextMeshProUGUI>().fontSize = 12;
        }
    }
}
