using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorFlip : MonoBehaviour {
    bool act = false;
    bool inTrigger;

    // Use this for initialization
    void Start() {
        inTrigger = false;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetButtonDown("Fire1") && inTrigger) {
            globalVars.switchFlippedC = true;
        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "torso") {
            inTrigger = true;
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.gameObject.name == "torso") {
            inTrigger = false;
        }
    }

}
