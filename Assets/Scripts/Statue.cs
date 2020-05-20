using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Statue : MonoBehaviour
{
    int StatueProgress = 0;
    public int Stage = 0;
    public Image image;

    // Update is called once per frame
    void Update()
    {
        StatueProgress = GameObject.Find("Resource_Holder").GetComponent<Resources>().Statprog;
        if (StatueProgress < 6)
        {
            if (StatueProgress == Stage)
            {
                image = GetComponent<Image>();
                var tempColor = image.color;
                tempColor.a = 1f;
                image.color = tempColor;
            }
            else
            {
                image = GetComponent<Image>();
                var tempColor = image.color;
                tempColor.a = 0f;
                image.color = tempColor;
            }
        }
    }
}
