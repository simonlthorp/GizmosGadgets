﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shapeDiamond : MonoBehaviour {

    bool active;
    bool under;
    private GameObject parent;
    Renderer rendCap, rendDia;


    // Use this for initialization
    void OnEnable() {
        parent = GameObject.Find("Gadget");
        rendCap = parent.transform.Find("gadCapsule").GetComponent<Renderer>();
        rendDia = parent.transform.Find("gadDiamond").GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update() {

        if (active) {
            if (globalVars.gadShape == null) {
                rendCap.enabled = false;
                rendDia.enabled = true;
                globalVars.gadShape = "Diamond";

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
        active = false;
    }
}
