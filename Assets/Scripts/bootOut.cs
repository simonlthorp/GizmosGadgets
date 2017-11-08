using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bootOut : MonoBehaviour {
    bool stay = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay(Collider other) {
        if (globalVars.switchFlippedD) {
            Destroy(other.gameObject);
            globalVars.help = false;
            globalVars.movement = false;
            globalVars.acivate(false);

        }
    }
}
