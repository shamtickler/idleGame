﻿using UnityEngine;
using System.Collections;

public class ExitGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ExitGameNow();
        }

	}

    public void ExitGameNow()
    {
        Application.Quit();
    }
}
