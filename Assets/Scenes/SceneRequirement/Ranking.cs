﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ranking : MonoBehaviour {

	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1")||Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(0);
        }
    }
}
