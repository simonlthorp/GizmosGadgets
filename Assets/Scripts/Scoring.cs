using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<TextMesh>().text = "$: 000";

    }

    void Update () {
        
        if (globalVars.score == 0) {
            GetComponent<TextMesh>().text = "$: 000";
        }
        else {
            GetComponent<TextMesh>().text = "$: " + globalVars.score;

        }
    }
}
