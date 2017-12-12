using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shapeFlip : MonoBehaviour {
    bool act = false;
    bool inTrigger;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetButtonDown("Fire1") && inTrigger) {
            globalVars.switchFlippedB = true;
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
