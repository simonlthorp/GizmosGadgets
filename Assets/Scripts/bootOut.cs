using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bootOut : MonoBehaviour {
    bool stay = true;
    bool cat;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (cat == true) {

            cat = false;
        }
	}

    void OnTriggerStay(Collider other) {
        if (globalVars.switchFlippedD) {
            Debug.Log("Switch Flipped D = " + globalVars.switchFlippedD.ToString());
            Destroy(other.gameObject);
            globalVars.help = false;
            globalVars.movement = false;
            globalVars.acivate(false);
            globalVars.gadShape = null;
            globalVars.switchFlippedD = false;
        }
    }
}
