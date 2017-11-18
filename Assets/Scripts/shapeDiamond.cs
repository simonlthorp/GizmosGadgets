using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shapeDiamond : MonoBehaviour {

    bool active;
    bool under;
    private GameObject parent;
    Renderer rendCap, rendDia;


    // Use this for initialization
    void OnEnable() {
        parent = GameObject.Find(globalVars.gadName);
        rendCap = parent.transform.Find("gadCapsule").GetComponent<Renderer>();
        rendDia = parent.transform.Find("gadDiamond").GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update() {

        if (active) {
            Debug.Log("CONE");
            rendCap.enabled = false;
            rendDia.enabled = true;
            globalVars.gadShape = "Diamond";

        }

    }

    void OnTriggerStay(Collider other) {
        under = true;
        if (other.gameObject.name == globalVars.gadName) {
            if (globalVars.switchFlippedB) {
                active = true;
                globalVars.switchFlippedB = false;
                Debug.Log("Falsed + D");
            }

        }
    }

    void OnTriggerExit(Collider other) {
        Debug.Log("D");
        under = false;
        active = false;
    }
}
