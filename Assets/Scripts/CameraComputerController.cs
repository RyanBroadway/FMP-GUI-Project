using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraComputerController : MonoBehaviour
{
    //This variable is so you can edit hight in-engine to find the right hight
    public float test = 10;
    
    void Update()
    {
        float cameraHeight = 11.36f;
        
        //change below to desired aspects
        float desiredAspect = 16f / 9f;
        
        float aspect = Camera.main.aspect;
        float ratio = desiredAspect / aspect;
        Camera.main.orthographicSize = (cameraHeight * ratio) * test;
    }

    private void FixedUpdate()
    {

    }
}
