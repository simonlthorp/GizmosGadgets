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
        Debug.Log("switchFlippedB: " + globalVars.switchFlippedB);
        if (Input.GetAxis("Fire1") != 0 && inTrigger) {
            if (Input.GetAxisRaw("Fire1") != 0) {
                Debug.Log("Switch B Flipped");
                globalVars.switchFlippedB = true;
            }
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
