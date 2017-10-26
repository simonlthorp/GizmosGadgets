using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropFlip : MonoBehaviour {
    bool act = false;
    bool inTrigger;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetAxis("Fire1") !=0 && inTrigger) {
            if (Input.GetAxisRaw("Fire1") != 0) {
                globalVars.switchFlippedA = true;
                Debug.Log("Activate Drop");
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
