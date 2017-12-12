using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rankingscore : MonoBehaviour {
    public Text ranking;
	// Use this for initialization
	void Start () {
        ranking.text=
        "1. " + PlayerPrefs.GetInt("4") + "\n" +
              "2. " + PlayerPrefs.GetInt("3") + "\n" +
               "3. " + PlayerPrefs.GetInt("2") + "\n" +
                "4. " + PlayerPrefs.GetInt("1") + "\n" +
                 "5. " + PlayerPrefs.GetInt("0"); 

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
