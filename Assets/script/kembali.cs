﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kembali : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.LoadLevel(0);
        }
	}

    public void kembalimenu()
    {
        Application.LoadLevel(0);
    }
}