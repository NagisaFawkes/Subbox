﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour 
{

	// Use this for initialization
	void Start() 
	{
		
	}
	
	// Update is called once per frame
	void Update() 
	{
        ProcessInput();
	}

    private void ProcessInput()
    {
        // Check if it's being thrusted
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Thrusting");
        }

        // Check if it's being rotated
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Rotating up");
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Rotating down");
        }
    }
}