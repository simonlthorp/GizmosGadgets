using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shapeSphere : MonoBehaviour {
    
    bool active;
    bool under;
    private GameObject capObj, triObj, sphObg, diaObj, parent;
    bool en;

    // Use this for initialization
    void OnEnable() {
        parent = GameObject.Find(globalVars.gadName);
        //        capObj = GameObject.Find("gadCapsule");
        //        sphObg = GameObject.Find("gadSphere");

        sphObg = parent.transform.Find("gadSphere").gameObject;
        capObj = parent.transform.Find("gadCapsule").gameObject;
        sphObg.SetActive(false);
        active = false;
        under = false;
        en = true;
        Debug.Log("PARENT: " + parent);
    }

    void OnDisable() {
        Debug.Log("Sphere Disabled");
    }
    // Update is called once per frame
    void Update () {
        if (en) {
            if (under == false) {
                globalVars.switchFlippedB = false;
            }
            if (active) {
                capObj.SetActive(false);
                sphObg.SetActive(true);
                active = false;
            }
        }


	}

    void OnTriggerStay(Collider other) {
        under = true;
        if (other.gameObject.name == globalVars.gadName) {
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
