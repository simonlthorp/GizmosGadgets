using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shapeSphere : MonoBehaviour {
    
    bool active;
    bool under;
   private GameObject capObj, triObj, sphObg, diaObj;

    // Use this for initialization
    void Start () {
        capObj = GameObject.Find("Capsule");
        sphObg = GameObject.Find("Sphere");
        sphObg.SetActive(false);
        active = false;
        under = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (under == false) {
            globalVars.switchFlippedB = false;
        }
        if (active) {

            capObj.SetActive(false);
            sphObg.SetActive(true);
            active = false;
        }
	}

    void OnTriggerStay(Collider other) {
        under = true;
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "Gadget") {
            if (globalVars.switchFlippedB) {
                active = true;
                globalVars.switchFlippedB = false;
            }

        }
    }

    void OnTriggerExit(Collider other) {
        under = false;
    }
}
