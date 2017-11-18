using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shapeSphere : MonoBehaviour {
    
    bool active;
    bool under;
    private GameObject parent;
    Renderer rendCap, rendSph;
    bool en;

    // Use this for initialization
    void OnEnable() {
        parent = GameObject.Find(globalVars.gadName);
        rendCap = parent.transform.Find("gadCapsule").GetComponent<Renderer>();
        rendSph = parent.transform.Find("gadSphere").GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update () {

        if (active) {
            Debug.Log("SPHERE");
            rendCap.enabled = false;
            rendSph.enabled = true;
            globalVars.gadShape = "Sphere";
        }

	}

    void OnTriggerStay(Collider other) {
        under = true;
        if (other.gameObject.name == globalVars.gadName) {
            if (globalVars.switchFlippedB) {
                active = true;
                globalVars.switchFlippedB = false;
                Debug.Log("Falsed + S");
            }

        }
    }

    void OnTriggerExit(Collider other) {
        Debug.Log("S");
        under = false;
        active = false;
    }
}
