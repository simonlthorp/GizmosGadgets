﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorREd : MonoBehaviour {

    public Material Red;
    GameObject gadget;
    bool active;
    bool under;

    // Use this for initialization
    void Start() {
        gadget = GameObject.Find("Gadget");
        active = false;
        under = false;
    }


    // Update is called once per frame
    void Update() {
        if (active) {
            Renderer[] renderers = gadget.GetComponentsInChildren<Renderer>();
            foreach (var r in renderers) {
                    r.material = Red;
                    globalVars.Red = true;
            }
            active = false;
        }
    }

    void OnTriggerStay(Collider other) {
        under = true;
        if (other.gameObject.name == "Gadget") {
            if (globalVars.switchFlippedC) {
                active = true;
                globalVars.switchFlippedC = false;
            }


        }

    }

    void OnTriggerExit(Collider other) {
        under = false;
    }
}
