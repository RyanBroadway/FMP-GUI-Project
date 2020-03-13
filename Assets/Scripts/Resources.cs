using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resources : MonoBehaviour
{
    public int Wood = 0;
    public int Stone = 0;
    public int Wheat = 0;

    public int Wood_Storage = 2500;
    public int Stone_Storage = 2500;
    public int Wheat_Storage = 2500;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timer());
        //Wood = Wood + Lumber_Wood;
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(1f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
